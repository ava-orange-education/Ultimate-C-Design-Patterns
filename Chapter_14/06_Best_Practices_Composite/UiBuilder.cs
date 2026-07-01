using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._06_Best_Practices_Composite
{
    class UiBuilder
    {
        public void Build()
        {
            Widget root = new ContainerWidget("Main Panel");
            Widget button1 = new ButtonWidget("Save");
            Widget button2 = new ButtonWidget("Cancel");

            root.Add(button1);
            root.Add(button2);

            root.Render();
        }
    }
}
