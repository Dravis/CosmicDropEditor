using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleDBDropEdit
{
    internal class MobSummaryData
    {
        public string ID {  get; set; }
        public string Name { get; set; } 
        public string itemCount { get; set; }

        public MobSummaryData(string ID) 
        {
            this.ID = ID;
        }
    }
}
