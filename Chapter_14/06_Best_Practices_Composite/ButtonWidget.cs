using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._06_Best_Practices_Composite
{
    class ButtonWidget : Widget
    {
        public ButtonWidget(string name)
            : base(name)
        { }

        public override void Render()
        {
            Console.WriteLine($"Button: {name}");
        }
    }
}
