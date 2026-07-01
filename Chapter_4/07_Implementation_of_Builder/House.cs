using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._07_Implementation_of_Builder
{
    public class House
    {
        public int Floors { get; }
        public string RoofType { get; }
        public bool HasGarden { get; }
        public bool HasGarage { get; }

        private House(Builder builder)
        {
            Floors = builder.Floors;
            RoofType = builder.RoofType;
            HasGarden = builder.HasGarden;
            HasGarage = builder.HasGarage;
        }

        public class Builder
        {
            public int Floors;
            public string RoofType;
            public bool HasGarden;
            public bool HasGarage;

            public Builder WithFloors(int floors) { Floors = floors; return this; }
            public Builder WithRoof(string roofType) { RoofType = roofType; return this; }
            public Builder WithGarden(bool hasGarden) { HasGarden = hasGarden; return this; }
            public Builder WithGarage(bool hasGarage) { HasGarage = hasGarage; return this; }

            public House Build() => new House(this);
        }
    }
}
