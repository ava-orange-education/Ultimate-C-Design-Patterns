using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._01_Intro_Bridge
{
    class Circle : Shape
    {
        public Circle(Renderer renderer) : base(renderer) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle:");
            base.Draw();
        }
    }
}
