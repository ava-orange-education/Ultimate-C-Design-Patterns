using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._03_Implementation_Prototype.Cloning_begin
{
    class CharacterPrototype : ICloneable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }

        public CharacterPrototype(string name, int health, int stamina)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
        }

        public object Clone()
        {
            return new CharacterPrototype(this.Name, this.Health, this.Stamina);
        }
    }
}
