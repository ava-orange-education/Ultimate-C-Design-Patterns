using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._01_Intro_Prototype
{
    class Warrior : CharacterPrototype
    {
        public int Stamina { get; private set; }

        public Warrior(int health, int stamina) : base(health)
        {
            Stamina = stamina;
        }

        public override CharacterPrototype Clone()
        {
            return new Warrior(Health, Stamina);
        }
    }
}
