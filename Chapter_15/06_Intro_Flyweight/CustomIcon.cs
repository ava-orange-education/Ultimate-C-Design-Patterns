using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._06_Intro_Flyweight
{
    class CustomIcon : Icon
    {
        private string customData;

        public CustomIcon(string data)
        {
            customData = data;
        }

        public override void Display(int x, int y)
        {
            Console.WriteLine($"Displaying custom icon at ({x},{y}) with data: {customData}");
        }
    }
}
