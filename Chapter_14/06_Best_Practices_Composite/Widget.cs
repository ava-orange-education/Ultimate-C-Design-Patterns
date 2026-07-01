using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._06_Best_Practices_Composite
{
    abstract class Widget
    {
        protected string name;

        public Widget(string name)
        {
            this.name = name;
        }

        public abstract void Render();
        public virtual void Add(Widget widget)
        {
            throw new NotSupportedException("Cannot add to a leaf widget.");
        }

        public virtual void Remove(Widget widget)
        {
            throw new NotSupportedException("Cannot remove from a leaf widget.");
        }
    }
}
