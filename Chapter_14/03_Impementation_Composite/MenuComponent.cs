using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._03_Impementation_Composite
{
    abstract class MenuComponent
    {
        protected string name;

        public MenuComponent(string name)
        {
            this.name = name;
        }

        public abstract void Display(int indent = 0);
        public abstract void Add(MenuComponent component);
        public abstract void Remove(MenuComponent component);
    }
}
