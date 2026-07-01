using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._01_Implementation_Composite
{
    abstract class LibraryItem
    {
        protected string label;

        public LibraryItem(string label)
        {
            this.label = label;
        }

        public abstract void Display();
        public abstract void Add(LibraryItem item);
        public abstract void Remove(LibraryItem item);
    }
}
