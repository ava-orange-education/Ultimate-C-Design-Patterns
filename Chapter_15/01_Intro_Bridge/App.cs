using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._01_Intro_Bridge
{
    class App
    {
        static void Main()
        {
            Shape shape = new Circle(new WindowsRenderer());
            shape.Draw();

            shape.Renderer = new MacRenderer();
            shape.Draw();
        }
    }
}
