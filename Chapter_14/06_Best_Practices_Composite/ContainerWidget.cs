using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._06_Best_Practices_Composite
{
    class ContainerWidget : Widget
    {
        private List<Widget> children = new List<Widget>();

        public ContainerWidget(string name)
            : base(name)
        { }

        public override void Add(Widget widget)
        {
            children.Add(widget);
        }

        public override void Remove(Widget widget)
        {
            children.Remove(widget);
        }

        public override void Render()
        {
            Console.WriteLine($"Container: {name}");
            foreach (var child in children)
            {
                child.Render();
            }
        }
    }
}
