using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._04_Examples_Bridge
{
    class WindowsRenderer : IRenderer
    {
        public void DrawDialog(string title, string message)
        {
            Console.WriteLine($"[Windows] Showing dialog: {title} - {message}");
        }
    }
}
