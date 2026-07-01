using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._09_Object_Creation_Workflows
{
    public class GameCharacter1
    {
        public string Name { get; }
        public int Level { get; }
        public int Health { get; }
        public string Weapon { get; }
        public string Armor { get; }
        public string[] Skills { get; }
        public List<string> Inventory { get; }

        private GameCharacter1(Builder builder)
        {
            Name = builder.Name;
            Level = builder.Level;
            Health = builder.Health;
            Weapon = builder.Weapon;
            Armor = builder.Armor;
            Skills = builder.Skills;
            Inventory = builder.Inventory;
        }

        public class Builder
        {
            public string Name;
            public int Level;
            public int Health;
            public string Weapon;
            public string Armor;
            public string[] Skills;
            public List<string> Inventory = new List<string>();

            public Builder WithName(string name) { Name = name; return this; }
            public Builder WithLevel(int level) { Level = level; return this; }
            public Builder WithHealth(int health) { Health = health; return this; }
            public Builder WithWeapon(string weapon) { Weapon = weapon; return this; }
            public Builder WithArmor(string armor) { Armor = armor; return this; }
            public Builder WithSkills(string[] skills) { Skills = skills; return this; }
            public Builder AddItemToInventory(string item) { Inventory.Add(item); return this; }

            public GameCharacter1 Build() => new GameCharacter1(this);
        }
    }

}
