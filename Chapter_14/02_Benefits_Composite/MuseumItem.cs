using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._02_Benefits_Composite
{
    abstract class MuseumItem
    {
        protected string title;

        public MuseumItem(string title)
        {
            this.title = title;
        }

        public abstract void Display();
        public abstract void Add(MuseumItem item);
        public abstract void Remove(MuseumItem item);
    }
}
