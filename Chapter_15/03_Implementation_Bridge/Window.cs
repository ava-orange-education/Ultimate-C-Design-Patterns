using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._03_Implementation_Bridge
{
    class Window : UIElement
    {
        public Window(IRenderer renderer) : base(renderer) { }

        public override void Render()
        {
            Console.WriteLine("Rendering a Window:");
            renderer.Draw("Window");
        }
    }
}
