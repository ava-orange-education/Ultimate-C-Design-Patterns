using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._07_Benefits_Flyweight
{
    class UnitFactory
    {
        private Dictionary<string, UnitType> types = new();

        public UnitType GetUnitType(string model, string texture)
        {
            string key = model + texture;
            if (!types.ContainsKey(key))
                types[key] = new UnitType(model, texture);
            return types[key];
        }
    }
}
