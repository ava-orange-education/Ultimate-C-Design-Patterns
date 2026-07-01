using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._07_Benefits_Flyweight
{
    class UnitType
    {
        public string Model { get; }
        public string Texture { get; }

        public UnitType(string model, string texture)
        {
            Model = model;
            Texture = texture;
        }

        public void Render(string position)
        {
            Console.WriteLine($"Rendering {Model} with {Texture} at {position}");
        }
    }
}
