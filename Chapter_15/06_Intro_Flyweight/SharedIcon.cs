using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._06_Intro_Flyweight
{
    class SharedIcon : Icon
    {
        private string imageData = "IconGraphicData"; // Intrinsic state

        public override void Display(int x, int y)
        {
            Console.WriteLine($"Displaying icon at ({x},{y}) with shared data: {imageData}");
        }
    }
}
