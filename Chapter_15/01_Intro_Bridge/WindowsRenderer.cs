using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._01_Intro_Bridge
{
    class WindowsRenderer : Renderer
    {
        public override void RenderShape()
        {
            Console.WriteLine("Rendering on Windows.");
        }
    }
}
