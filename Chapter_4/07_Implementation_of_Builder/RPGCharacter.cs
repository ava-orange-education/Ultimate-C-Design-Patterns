using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._07_Implementation_of_Builder
{
    public class RPGCharacter
    {
        public string Name { get; }
        public int Strength { get; }
        public int Agility { get; }
        public int MagicPower { get; }

        private RPGCharacter(Builder builder)
        {
            Name = builder.Name;
            Strength = builder.Strength;
            Agility = builder.Agility;
            MagicPower = builder.MagicPower;
        }

        public class Builder
        {
            public string Name;
            public int Strength;
            public int Agility;
            public int MagicPower;

            public Builder WithName(string name) { Name = name; return this; }
            public Builder WithStrength(int strength) { Strength = strength; return this; }
            public Builder WithAgility(int agility) { Agility = agility; return this; }
            public Builder WithMagicPower(int magic) { MagicPower = magic; return this; }
            public RPGCharacter Build() => new RPGCharacter(this);
        }
    }
}
