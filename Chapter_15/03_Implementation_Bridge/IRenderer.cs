using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._03_Implementation_Bridge
{
    interface IRenderer
    {
        void Draw(string elementType, string theme);
    }
}
