using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleDBDropEdit
{
    public class MobDropData
    {
        public long ID {get; set;}
        public int MobId { get; set; }
        public int ItemId { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int QuestId { get; set; }
        public int Chance { get; set; }

        public string Name { get; set; }
        public bool Continent { get; set; } //used for Global Drops
    }
}
