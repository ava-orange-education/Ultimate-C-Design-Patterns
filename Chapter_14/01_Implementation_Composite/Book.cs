using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._01_Implementation_Composite
{
    class Book : LibraryItem
    {
        public Book(string label)
            : base(label)
        { }

        public override void Display()
        {
            Console.WriteLine($"Book: {label}");
        }

        public override void Add(LibraryItem item)
        {
            throw new NotImplementedException("Books can't contain other items.");
        }

        public override void Remove(LibraryItem item)
        {
            throw new NotImplementedException("Books can't remove items.");
        }
    }
}
