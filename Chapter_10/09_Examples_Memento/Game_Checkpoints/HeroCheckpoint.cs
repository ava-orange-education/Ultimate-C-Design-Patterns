using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Game_Checkpoints
{
    public class HeroCheckpoint
    {
        public int Level { get; }
        public List<string> Items { get; }

        public HeroCheckpoint(int level, List<string> items)
        {
            Level = level;
            Items = items;
        }
    }
}
