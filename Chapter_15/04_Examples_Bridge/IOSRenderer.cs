using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._04_Examples_Bridge
{
    class IOSRenderer : IRenderer
    {
        public void DrawDialog(string title, string message)
        {
            Console.WriteLine($"[iOS] Cupertino alert: {title} => {message}");
        }
    }
}
