using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._02_Benefits_Composite
{
    class ExhibitRoom : MuseumItem
    {
        List<MuseumItem> items = new List<MuseumItem>();

        public ExhibitRoom(string title)
            : base(title)
        { }

        public override void Add(MuseumItem item)
        {
            items.Add(item);
        }

        public override void Remove(MuseumItem item)
        {
            items.Remove(item);
        }

        public override void Display()
        {
            Console.WriteLine($"Room: {title}");
            foreach (var item in items)
            {
                item.Display();
            }
        }
    }
}
