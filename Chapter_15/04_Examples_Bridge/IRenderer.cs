using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._04_Examples_Bridge
{
    interface IRenderer
    {
        void DrawDialog(string title, string message);
    }
}
