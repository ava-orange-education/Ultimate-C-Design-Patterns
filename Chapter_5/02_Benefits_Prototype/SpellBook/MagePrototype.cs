using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._02_Benefits_Prototype.SpellBook
{
    class MagePrototype
    {
        public string Name { get; set; }
        public SpellBook SpellBook { get; set; }

        public MagePrototype(string name, SpellBook spellBook)
        {
            Name = name;
            SpellBook = spellBook;
        }

        public MagePrototype Clone()
        {
            return new MagePrototype(this.Name, this.SpellBook.DeepCopy());
        }
    }
}
