using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._03_Impementation_Composite
{
    class MenuGroup : MenuComponent
    {
        private List<MenuComponent> items = new List<MenuComponent>();

        public MenuGroup(string name)
            : base(name)
        { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "[ " + name + " ]");
            foreach (var item in items)
            {
                item.Display(indent + 2);
            }
        }

        public override void Add(MenuComponent component)
        {
            items.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            items.Remove(component);
        }
    }
}
