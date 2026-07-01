using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._03_Implementation_Bridge
{
    class Button : UIElement
    {
        public Button(IRenderer renderer, string theme) : base(renderer, theme) { }

        public override void Render()
        {
            Console.WriteLine("Rendering a Button:");
            renderer.Draw("Button", theme);
        }
    }
}
