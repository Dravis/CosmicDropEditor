using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleDBDropEdit
{
    internal class MobData
    {
        public string MobId { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Exp { get; set; }
        public int PhysicalAttack { get; set; }
        public int PhysicalDefence { get; set; }
        public int MagicAttack { get; set; }
        public int MagicDefence { get; set; }
        public int Speed { get; set; }
        public int Accuracy { get; set; }
        public int Evasion { get; set; }

    }
}
