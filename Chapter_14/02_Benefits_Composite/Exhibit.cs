using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._02_Benefits_Composite
{
    class Exhibit : MuseumItem
    {
        public Exhibit(string title)
            : base(title)
        { }

        public override void Display()
        {
            Console.WriteLine($"Exhibit: {title}");
        }

        public override void Add(MuseumItem item)
        {
            throw new NotImplementedException("Exhibits can't contain other items.");
        }

        public override void Remove(MuseumItem item)
        {
            throw new NotImplementedException("Exhibits can't remove items.");
        }
    }
}
