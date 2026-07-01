using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._03_Impementation_Composite
{
    class MenuItem : MenuComponent
    {
        public MenuItem(string name)
            : base(name)
        { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "- " + name);
        }

        public override void Add(MenuComponent component)
        {
            throw new NotImplementedException("Cannot add to a menu item.");
        }

        public override void Remove(MenuComponent component)
        {
            throw new NotImplementedException("Cannot remove from a menu item.");
        }
    }
}
