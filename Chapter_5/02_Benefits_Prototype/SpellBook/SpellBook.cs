using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._02_Benefits_Prototype.SpellBook
{
    class SpellBook
    {
        public string[] Spells { get; set; }

        public SpellBook(string[] spells)
        {
            Spells = spells;
        }

        public SpellBook DeepCopy()
        {
            return new SpellBook((string[])Spells.Clone());
        }
    }
}
