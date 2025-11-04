using System.Windows.Forms;

namespace MapleDBDropEdit
{
    public partial class DropEditor : Form
    {
        List<DatabaseConfig> databaseConfigs;
        MapleDatabase mapleDB;
        WZDataProvider wzProvider;
        Bitmap mobImage;

        ImageList SmallImageList;
        List<MobDropData> currentDropsData;
        ContextMenuStrip contextMenu;
        int contextItemId;

        public DropEditor()
        {
            InitializeComponent();
            listViewMobs.FullRowSelect = true;

            mapleDB = new MapleDatabase();
            mobImage = new Bitmap(2, 2);
            SmallImageList = new ImageList();
            listViewDrops.SmallImageList = SmallImageList;
            listViewDrops.SmallImageList.ImageSize = new Size(32, 32);

            databaseConfigs = DatabaseConfigManager.Load();
            UpdateConnectionCombobox();
            toolStripStatusLabel.Text = "Config Loaded";

            contextMenu = new ContextMenuStrip();
            contextMenu.ItemClicked += contextMenu_ItemClicked;
            contextMenu.Items.Add("Copy Item Id");
            contextMenu.Items.Add("Edit..");
            contextItemId = 0;
        }

        private void UpdateConnectionCombobox()
        {
            comboBoxConnection.Items.Clear();
            foreach (DatabaseConfig config in databaseConfigs)
            {
                comboBoxConnection.Items.Add(config);
            }
        }

        private void UpdateMobInfo()
        {
            string mobId = listViewMobs.SelectedItems[0].SubItems[0].Text;
            mobImage = wzProvider.GetMobImage(mobId);
            pictureBoxMob.Refresh();
            toolStripStatusLabel.Text = $"Loaded Mob Id {mobId}";

            MobData mobData = wzProvider.GetMobData(mobId);
            if (mobData != null)
            {
                labelLevel.Text = mobData.Level.ToString();
                labelHP.Text = mobData.HP.ToString();
                labelMP.Text = mobData.MP.ToString();
                labelXP.Text = mobData.Exp.ToString();
                labelPAtt.Text = mobData.PhysicalAttack.ToString();
                labelPDef.Text = mobData.PhysicalDefence.ToString();
                labelMAtt.Text = mobData.MagicAttack.ToString();
                labelMDef.Text = mobData.MagicDefence.ToString();
                labelSpeed.Text = mobData.Speed.ToString();
                labelAcc.Text = mobData.Accuracy.ToString();
                labelEva.Text = mobData.Evasion.ToString();
            }
            else
            {
                labelLevel.Text = "###";
                labelHP.Text = "#####";
                labelMP.Text = "#####";
                labelXP.Text = "#####";
                labelPAtt.Text = "###";
                labelPDef.Text = "###";
                labelMAtt.Text = "###";
                labelMDef.Text = "###";
                labelSpeed.Text = "###";
                labelAcc.Text = "###";
                labelEva.Text = "###";
            }
        }
        private void SetupMobSummaryList(string mobId = "")
        {
            listViewMobs.Items.Clear();

            List<MobSummaryData> mobData = mapleDB.GetGlobalDropsSummary();
            mobData.AddRange(mapleDB.GetMobsSummaryData());

            int mobIndexToLocate = 0;
            foreach (MobSummaryData mobDataItem in mobData)
            {
                if (mobId != "" && mobDataItem.ID == mobId)
                    mobIndexToLocate = listViewMobs.Items.Count;

                ListViewItem listViewItem = new ListViewItem(mobDataItem.ID);
                mobDataItem.Name = wzProvider.GetMobName(mobDataItem.ID);
                listViewItem.SubItems.Add(mobDataItem.Name);
                listViewItem.SubItems.Add(mobDataItem.itemCount.ToString());
                listViewMobs.Items.Add(listViewItem);
            }

            if (mobId != "")
                listViewMobs.EnsureVisible(mobIndexToLocate);
        }

        private void FillMobDropTable()
        {
            string mobId = listViewMobs.SelectedItems[0].SubItems[0].Text;

            listViewDrops.Items.Clear();
            SmallImageList.Images.Clear();

            if (mobId == "Global")
                currentDropsData = mapleDB.GetGlobalDrops();
            else
                currentDropsData = mapleDB.GetMobDropData(mobId);

            foreach (MobDropData dropDataItem in currentDropsData)
            {
                ListViewItem listViewItem = new ListViewItem("");
                Icon icon = ImageUtil.ConvertBitmapToIcon(wzProvider.GetItemIcon(dropDataItem.ItemId.ToString()));
                if (icon.Height != 0)
                {
                    SmallImageList.Images.Add(dropDataItem.ItemId.ToString(), icon);
                    listViewItem.ImageKey = dropDataItem.ItemId.ToString();
                }

                listViewItem.SubItems.Add(dropDataItem.ItemId.ToString());
                dropDataItem.Name = wzProvider.GetItemName(dropDataItem.ItemId.ToString());
                listViewItem.SubItems.Add(dropDataItem.Name);
                listViewItem.SubItems.Add(dropDataItem.MinimumQuantity.ToString());
                listViewItem.SubItems.Add(dropDataItem.MaximumQuantity.ToString());
                listViewItem.SubItems.Add(dropDataItem.QuestId.ToString());
                listViewItem.SubItems.Add(dropDataItem.Chance.ToString());
                listViewDrops.Items.Add(listViewItem);
            }

        }

        private void contextMenu_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Copy Item Id")
            {
                Clipboard.SetText(contextItemId.ToString());
            }
            if (e.ClickedItem.Text == "Edit..")
            {
                MobDropData dropData = currentDropsData.First(x => x.ItemId == contextItemId);
                DropDataEdit editForm = new DropDataEdit(DropDataEdit.EditorState.Edit);
                editForm.SetData(dropData);
                editForm.ShowDialog();
                if (editForm.Save)
                {
                    if (editForm.dropData.MobId != 0)
                        mapleDB.UpdateDrop(editForm.dropData);
                    else
                        mapleDB.UpdateGlobalDrop(editForm.dropData);
                    FillMobDropTable();
                }
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm();
            connectForm.ShowDialog();
            databaseConfigs.Add(connectForm.Config);
            UpdateConnectionCombobox();

            DatabaseConfigManager.Save(databaseConfigs);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            DatabaseConfig config = (DatabaseConfig)comboBoxConnection.SelectedItem;

            if (!mapleDB.IsConnected())
            {
                if (config != null)
                {
                    mapleDB.Connect(config.Host, config.Port, config.Database, config.Username, config.Password);
                    comboBoxConnection.Enabled = false;
                    buttonConnect.Text = "Disconnect";

                    if (mapleDB.IsConnected())
                    {
                        toolStripStatusLabel.Text = "Connected to Database";
                        wzProvider = new WZDataProvider(config.WZPath);
                        SetupMobSummaryList();
                    }
                }
            }
            else
            {
                mapleDB.Disconnect();
                comboBoxConnection.Enabled = true;
                buttonConnect.Text = "Connect..";
                toolStripStatusLabel.Text = "Disconnected";
            }
        }

        private void listViewMobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMobs.SelectedItems.Count != 0 && listViewMobs.Focused)
            {
                FillMobDropTable();
                UpdateMobInfo();
            }
        }

        private void pictureBoxMob_Paint(object sender, PaintEventArgs e)
        {
            if (mobImage != null)
            {
                // Calculate X for horizontal centering
                int x = (pictureBoxMob.Width - mobImage.Width) / 2;

                // Calculate Y for bottom alignment
                int y = pictureBoxMob.Height - mobImage.Height - 1;

                // Draw the image at the calculated position
                e.Graphics.DrawImage(mobImage, x, y, mobImage.Width, mobImage.Height);
            }

        }

        private void buttonEditDrop_Click(object sender, EventArgs e)
        {
            if (listViewDrops.SelectedItems.Count != 0)
            {

                int itemId = int.Parse(listViewDrops.SelectedItems[0].SubItems[1].Text);
                MobDropData dropData = currentDropsData.First(x => x.ItemId == itemId);

                DropDataEdit editForm = new DropDataEdit(DropDataEdit.EditorState.Edit);
                editForm.SetData(dropData);
                editForm.ShowDialog();
                if (editForm.Save)
                {
                    if (editForm.dropData.MobId != 0)
                        mapleDB.UpdateDrop(editForm.dropData);
                    else
                        mapleDB.UpdateGlobalDrop(editForm.dropData);

                    FillMobDropTable();
                }
            }
        }

        //4001006
        private void buttonAddDrop_Click(object sender, EventArgs e)
        {
            if (listViewMobs.SelectedItems.Count != 0)
            {
                string mobIdString = listViewMobs.SelectedItems[0].SubItems[0].Text;
                int mobId = 0;
                if (mobIdString != "Global")
                    mobId = int.Parse(mobIdString);

                DropDataEdit editForm = new DropDataEdit(DropDataEdit.EditorState.Add);
                editForm.SetData(mobId);
                editForm.ShowDialog();
                if (editForm.Save)
                {
                    if (editForm.dropData.MobId != 0)
                        mapleDB.CreateDrop(editForm.dropData);
                    else
                        mapleDB.CreateGlobalDrop(editForm.dropData);

                    FillMobDropTable();
                }
            }
        }

        private void buttonDeleteDrop_Click(object sender, EventArgs e)
        {
            if (listViewDrops.SelectedItems.Count != 0)
            {
                int itemId = int.Parse(listViewDrops.SelectedItems[0].SubItems[1].Text);
                MobDropData dropData = currentDropsData.First(x => x.ItemId == itemId);
                DialogResult dg = MessageBox.Show($"Are you sure you want to delete drop {itemId}", "Delete", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    if (dropData.MobId != 0)
                        mapleDB.DeleteDrop(dropData.ID);
                    else
                        mapleDB.DeleteGlobalDrop(dropData.ID);

                    FillMobDropTable();
                }
            }
        }

        private void listViewDrops_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextItemId = int.Parse(listViewDrops.GetItemAt(e.X, e.Y).SubItems[1].Text);
                contextMenu.Show(listViewDrops, e.Location);
            }
        }

        private void buttonAddMob_Click(object sender, EventArgs e)
        {
            DropDataEdit editForm = new DropDataEdit(DropDataEdit.EditorState.AddMonster);
            editForm.ShowDialog();
            if (editForm.Save)
            {
                if (editForm.dropData.MobId != 0)
                    mapleDB.CreateDrop(editForm.dropData);
                else
                    mapleDB.CreateGlobalDrop(editForm.dropData);
                SetupMobSummaryList(editForm.dropData.ID.ToString());
                FillMobDropTable();
            }
        }

        private void buttonEditConnections_Click(object sender, EventArgs e)
        {
            EditConnections editConnectionsForm = new EditConnections();
            editConnectionsForm.ShowDialog();

            databaseConfigs = DatabaseConfigManager.Load();
            UpdateConnectionCombobox();
        }
    }
}
