using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._08_Implementation_Flyweight
{
    class Game
    {
        static void Main()
        {
            Forest forest = new Forest();

            for (int i = 0; i < 10000; i++)
            {
                int x = i % 100;
                int y = i / 100;
                forest.PlantTree(x, y, "OakTexture", "OakMesh");
            }

            forest.Draw();
        }
    }
}
