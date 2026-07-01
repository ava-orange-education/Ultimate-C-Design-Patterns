using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._07_Benefits_Flyweight
{
    class Game
    {
        static void Main()
        {
            UnitFactory factory = new UnitFactory();
            List<GameUnit> units = new List<GameUnit>();

            for (int i = 0; i < 10000; i++)
            {
                var type = factory.GetUnitType("Orc", "GreenSkin");
                var unit = new GameUnit($"Position {i}", type);
                units.Add(unit);
            }

            units[0].Draw();
            units[9999].Draw();
        }
    }
}
