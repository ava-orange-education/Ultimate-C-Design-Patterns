using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._01_Implementation_Composite
{
    class Shelf : LibraryItem
    {
        List<LibraryItem> contents = new List<LibraryItem>();

        public Shelf(string label)
            : base(label)
        { }

        public override void Add(LibraryItem item)
        {
            contents.Add(item);
        }

        public override void Remove(LibraryItem item)
        {
            contents.Remove(item);
        }

        public override void Display()
        {
            Console.WriteLine($"Shelf: {label}");
            foreach (LibraryItem item in contents)
            {
                item.Display();
            }
        }
    }
}
