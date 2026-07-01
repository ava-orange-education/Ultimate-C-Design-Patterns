using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._06_Builder_Pattern_Elevates
{
    public class RPGCharacter
    {
        public string Name { get; }
        public int Strength { get; }
        public int Agility { get; }
        public int Intelligence { get; }

        private RPGCharacter(Builder builder)
        {
            Name = builder.Name;
            Strength = builder.Strength;
            Agility = builder.Agility;
            Intelligence = builder.Intelligence;
        }

        public class Builder
        {
            public string Name;
            public int Strength;
            public int Agility;
            public int Intelligence;

            public Builder WithName(string name) { Name = name; return this; }
            public Builder WithStrength(int strength) { Strength = strength; return this; }
            public Builder WithAgility(int agility) { Agility = agility; return this; }
            public Builder WithIntelligence(int intelligence) { Intelligence = intelligence; return this; }

            public RPGCharacter Build() => new RPGCharacter(this);
        }
    }
}
