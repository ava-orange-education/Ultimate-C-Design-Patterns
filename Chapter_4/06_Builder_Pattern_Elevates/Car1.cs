using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._06_Builder_Pattern_Elevates
{
    public class Car1
    {
        public string Engine { get; }
        public int Wheels { get; }
        public string Color { get; }
        public bool HasGPS { get; }
        public bool HasSunroof { get; }
        public bool HasTurbo { get; }
        public int Airbags { get; }

        private Car1(Builder builder)
        {
            Engine = builder.Engine;
            Wheels = builder.Wheels;
            Color = builder.Color;
            HasGPS = builder.HasGPS;
            HasSunroof = builder.HasSunroof;
            HasTurbo = builder.HasTurbo;
            Airbags = builder.Airbags;
        }

        public class Builder
        {
            public string Engine;
            public int Wheels;
            public string Color;
            public bool HasGPS;
            public bool HasSunroof;
            public bool HasTurbo;
            public int Airbags;

            public Builder WithEngine(string engine) { Engine = engine; return this; }
            public Builder WithWheels(int wheels) { Wheels = wheels; return this; }
            public Builder WithColor(string color) { Color = color; return this; }
            public Builder WithGPS(bool hasGPS) { HasGPS = hasGPS; return this; }
            public Builder WithSunroof(bool hasSunroof) { HasSunroof = hasSunroof; return this; }
            public Builder WithTurbo(bool hasTurbo) { HasTurbo = hasTurbo; return this; }
            public Builder WithAirbags(int airbags) { Airbags = airbags; return this; }

            public Car1 Build() => new Car1(this);
        }
    }
}
