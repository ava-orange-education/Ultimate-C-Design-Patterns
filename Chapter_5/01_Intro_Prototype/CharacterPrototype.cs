using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._01_Intro_Prototype
{
    abstract class CharacterPrototype
    {
        public int Health { get; protected set; }

        public CharacterPrototype(int health)
        {
            Health = health;
        }

        public abstract CharacterPrototype Clone();
    }
}
