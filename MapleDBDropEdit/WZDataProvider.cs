using reWZ;
using reWZ.WZProperties;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MapleDBDropEdit
{
    internal class WZDataProvider
    {
        static WZDataProvider instance;
        
        WZFile StringsWZ;
        WZFile ItemWZ;
        WZFile CharacterWZ;
        WZFile MobWZ;

        public WZDataProvider(string WzPath) 
        {         
            StringsWZ = new WZFile(WzPath + "String.wz", WZVariant.GMS, true);
            MobWZ = new WZFile(WzPath + "Mob.wz", WZVariant.GMS, true);
            ItemWZ = new WZFile(WzPath +"Item.wz", WZVariant.GMS, true);
            CharacterWZ = new WZFile(WzPath + "Character.wz", WZVariant.GMS, true);
            
            instance = this;
        }

        public static WZDataProvider GetInstance()
        {
            return instance;
        }

        public Bitmap GetMobImage(string id) 
        {
            Bitmap bmp = null;
            if (id.Length == 6) 
                id = id.Insert(0, "0");

            string path = $"{id}.img/stand/0";
            try
            {
                bmp = MobWZ.ResolvePath(path).ValueOrDie<Bitmap>();
            }
            catch (Exception e) { }
            
            if (bmp == null) 
            { 
                try
                {
                    path = $"{id}.img/fly/0";
                    bmp=MobWZ.ResolvePath(path).ValueOrDie<Bitmap>();
                }
                catch (Exception e)
                {
                    bmp = new Bitmap(2,2);
                }
            }

            return bmp;
        }

        public MobData GetMobData(string id)
        {
            if (id.Length == 6)
                id = id.Insert(0, "0");

            MobData mobData = null;
            try
            {
                var mobInfoNode = (WZSubProperty)MobWZ.ResolvePath($"{id}.img/info");
                mobData = new MobData();
                mobData.MobId = id;
                mobData.Level = mobInfoNode.ResolvePath("level").ValueOrDefault(0);
                mobData.HP = mobInfoNode.ResolvePath("maxHP").ValueOrDefault(0);
                mobData.MP = mobInfoNode.ResolvePath("maxMP").ValueOrDefault(0);
                mobData.Exp = mobInfoNode.ResolvePath("exp").ValueOrDefault(0);
                mobData.PhysicalAttack = mobInfoNode.ResolvePath("PADamage").ValueOrDefault(0);
                mobData.PhysicalDefence = mobInfoNode.ResolvePath("PDDamage").ValueOrDefault(0);
                mobData.MagicAttack = mobInfoNode.ResolvePath("MADamage").ValueOrDefault(0);
                mobData.MagicDefence = mobInfoNode.ResolvePath("MDDamage").ValueOrDefault(0);
                mobData.Accuracy = mobInfoNode.ResolvePath("acc").ValueOrDefault(0);
                mobData.Evasion = mobInfoNode.ResolvePath("eva").ValueOrDefault(0);
                mobData.Speed = mobInfoNode.ResolvePath("speed").ValueOrDefault(0);

            }
            catch { }

            return mobData;
        }

        public string GetMobName(string id)
        {
            string name = "";
            try
            {
                name = StringsWZ.ResolvePath($"Mob.img/{id}/name").ValueOrDie<String>();
            }
            catch
            {
                name = "??";
            }

            return name;
        }
 
        public string GetItemName(string id)
        {
            string path = "";
            string name = "";

            if (id == "0") { name = "Mesos"; }
            if (id[0] == '2') { path = $"Consume.img/{id}/name"; }
            if (id[0] == '3') { path = $"Ins.img/{id}/name"; }
            if (id[0] == '4') { path = $"Etc.img/Etc/{id}/name"; }         
            if (id[0] == '5') { path = $"Pet.img/{id}/name"; }
            if (path == "" && name == "")
            {
                string start3 = id[0..3];
                if (start3 == "100") { path = $"Eqp.img/Eqp/Cap/{id}/name"; }
                if (start3 == "101" ||
                    start3 == "102" ||
                    start3 == "103" ||
                    start3 == "112" ||
                    start3 == "114") { path = $"Eqp.img/Eqp/Accessory/{id}/name"; }
                if (start3 == "104") { path = $"Eqp.img/Eqp/Coat/{id}/name"; }
                if (start3 == "105") { path = $"Eqp.img/Eqp/Longcoat/{id}/name"; }
                if (start3 == "106") { path = $"Eqp.img/Eqp/Pants/{id}/name"; }
                if (start3 == "107") { path = $"Eqp.img/Eqp/Shoes/{id}/name"; }
                if (start3 == "108") { path = $"Eqp.img/Eqp/Glove/{id}/name"; }
                if (start3 == "109") { path = $"Eqp.img/Eqp/Shield/{id}/name"; }
                if (start3 == "110") { path = $"Eqp.img/Eqp/Cape/{id}/name"; }
                if (start3 == "111") { path = $"Eqp.img/Eqp/Ring/{id}/name"; }

                string start2 = id[0..2];
                if (start2 == "13" ||
                    start2 == "14" ||
                    start2 == "16" ||
                    start2 == "17" ) { path = $"Eqp.img/Eqp/Weapon/{id}/name"; }
                if (start2 == "18") { path = $"Eqp.img/Eqp/PetEquip/{id}/name"; }
            }
            
            
            if (path != "")
            {
                try
                {
                    name = StringsWZ.ResolvePath(path).ValueOrDie<String>();
                }
                catch
                {
                    name = "??";
                }
            }

            return name;
        }

        public Dictionary<string, string> GetAllItemIDNames() 
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            WZImage consumeStrings = (WZImage)StringsWZ.ResolvePath("Consume.img");
            foreach (var wzObj in consumeStrings)
            {
                if (wzObj is WZSubProperty)
                {
                    try
                    {
                        items.Add(wzObj.Name, wzObj["name"].ValueOrDefault<string>(""));
                    }
                    catch
                    { }
                }
            }

            WZImage insStrings = (WZImage)StringsWZ.ResolvePath("Ins.img");
            foreach (var wzObj in insStrings)
            {
                if (wzObj is WZSubProperty)
                {
                    try
                    {
                        items.Add(wzObj.Name, wzObj["name"].ValueOrDefault<string>(""));
                    }
                    catch
                    { }
                }
            }

            WZImage petStrings = (WZImage)StringsWZ.ResolvePath("Pet.img");
            foreach (var wzObj in petStrings)
            {
                if (wzObj is WZSubProperty)
                {
                    try
                    {
                        items.Add(wzObj.Name, wzObj["name"].ValueOrDefault<string>(""));
                    }
                    catch
                    { }
                }
            }

            WZSubProperty etcStrings = (WZSubProperty)StringsWZ.ResolvePath("Etc.img/Etc");
            foreach (var wzObj in etcStrings)
            {
                if (wzObj is WZSubProperty)
                {
                    try
                    {
                        items.Add(wzObj.Name, wzObj["name"].ValueOrDefault<string>(""));
                    }
                    catch
                    { }
                }
            }

            WZSubProperty equipStrings = (WZSubProperty)StringsWZ.ResolvePath("Eqp.img/Eqp");
            foreach (var equipFolder in equipStrings)
            {
                foreach (var wzObj in equipFolder)
                {
                    if (wzObj is WZSubProperty)
                    {
                        try
                        {
                            items.Add(wzObj.Name, wzObj["name"].ValueOrDefault<string>(""));
                        }
                        catch
                        { }
                    }
                }
            }

            return items;
        }


        public Bitmap GetItemIcon(string id)
        {

            Bitmap bmp = null;
            if (id.Length == 7 || id.Length == 1)
                id = id.Insert(0, "0");

            string path = "";
            if (id == "00") 
            {
                path = $"Special/0900.img/09000003/iconRaw/3";
                bmp = ItemWZ.ResolvePath(path).ValueOrDie<Bitmap>();
                return bmp;
            }
            
            if (id[0..2] == "02") { path = $"Consume/{id[0..4]}.img"; }
            if (id[0..2] == "04") { path = $"Etc/{id[0..4]}.img"; }
            if (path != "")
            {
                try
                {
                    WZObject wzObj = ItemWZ.ResolvePath($"{path}/{id}/info/iconRaw");
                    if (wzObj is WZUOLProperty)
                    {
                        string newPath = ((WZUOLProperty)wzObj).Value.Substring(6);
                        bmp = ItemWZ.ResolvePath($"{path}/{newPath}").ValueOrDie<Bitmap>();
                    }
                    else if (wzObj is WZCanvasProperty)
                    {
                        bmp = ItemWZ.ResolvePath($"{path}/{id}/info/iconRaw").ValueOrDie<Bitmap>();
                    }

                }
                catch (Exception e) { }
            }         

            if (path == "")
            {
                string typeId = id[0..4];
                if (typeId == "0100") { path = $"Cap/{id}.img/info/iconRaw"; }
                if (typeId == "0101" ||
                    typeId == "0102" ||
                    typeId == "0103" ||
                    typeId == "0112" ||
                    typeId == "0114") { path = $"Accessory/{id}.img/info/iconRaw"; }
                if (typeId == "0104") { path = $"Coat/{id}.img/info/iconRaw"; }
                if (typeId == "0105") { path = $"Longcoat/{id}.img/info/iconRaw"; }
                if (typeId == "0106") { path = $"Pants/{id}.img/info/iconRaw"; }
                if (typeId == "0107") { path = $"Shoes/{id}.img/info/iconRaw"; }
                if (typeId == "0108") { path = $"Glove/{id}.img/info/iconRaw"; }
                if (typeId == "0109") { path = $"Shield/{id}.img/info/iconRaw"; }
                if (typeId == "0110") { path = $"Cape/{id}.img/info/iconRaw"; }

                string start2 = id[0..3];
                if (start2 == "013" ||
                    start2 == "014" ||
                    start2 == "016" ||
                    start2 == "017") { path = $"Weapon/{id}.img/info/iconRaw"; }

                if (path != "")
                {
                    try
                    {
                        bmp = CharacterWZ.ResolvePath(path).ValueOrDie<Bitmap>();
                    }
                    catch (Exception e) { }
                }
            }

            if (bmp == null) 
                bmp = new Bitmap(2, 2);


            return bmp;
        }
    }
}
