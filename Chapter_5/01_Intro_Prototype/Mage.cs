using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._01_Intro_Prototype
{
    class Mage : CharacterPrototype
    {
        public int Mana { get; private set; }

        public Mage(int health, int mana) : base(health)
        {
            Mana = mana;
        }

        public override CharacterPrototype Clone()
        {
            return new Mage(Health, Mana);
        }
    }
}
