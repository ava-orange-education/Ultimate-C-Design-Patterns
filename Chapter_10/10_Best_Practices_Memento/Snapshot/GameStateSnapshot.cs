using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._10_Best_Practices_Memento.Snapshot
{
    [Serializable]
    public class GameStateSnapshot
    {
        public int PlayerLevel { get; set; }
        public List<string> Inventory { get; set; }
    }
}
