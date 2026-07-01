using Chapter_5._03_Implementation_Prototype.Hidden_Danger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._03_Implementation_Prototype.Deep_Copy
{
    class GameAvatar : ICloneable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public GameAvatar(string name, int health, Weapon weapon)
        {
            Name = name;
            Health = health;
            EquippedWeapon = weapon;
        }

        public object Clone()
        {
            return new GameAvatar(this.Name, this.Health, new Weapon(this.EquippedWeapon.Name));
        }

        public void Customize(string newName, int newHealth)
        {
            Name = newName;
            Health = newHealth;
        }
    }
}
