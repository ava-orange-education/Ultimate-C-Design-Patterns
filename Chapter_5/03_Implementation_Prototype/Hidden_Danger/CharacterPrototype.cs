using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._03_Implementation_Prototype.Hidden_Danger
{
    class CharacterPrototype : ICloneable
    {
        public string Name { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public CharacterPrototype(string name, Weapon weapon)
        {
            Name = name;
            EquippedWeapon = weapon;
        }

        public object Clone()
        {
            return new CharacterPrototype(this.Name, this.EquippedWeapon); // SHALLOW COPY WARNING
        }
    }
}
