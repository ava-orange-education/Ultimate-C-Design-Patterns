using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._03_Implementation_Bridge
{
    class WindowsRenderer : IRenderer
    {
        public void Draw(string elementType, string theme)
        {
            Console.WriteLine($"[Windows - {theme}] Drawing {elementType} with DirectX.");
        }
    }
}
