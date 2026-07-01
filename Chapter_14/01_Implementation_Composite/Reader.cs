using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._01_Implementation_Composite
{
    class Reader
    {
        public void Browse()
        {
            LibraryItem mainShelf = new Shelf("Main Shelf");
            LibraryItem book1 = new Book("Design Patterns Explained");
            LibraryItem book2 = new Book("C# in Depth");
            Shelf subShelf = new Shelf("Sub Shelf");

            subShelf.Add(book2);
            mainShelf.Add(book1);
            mainShelf.Add(subShelf);

            mainShelf.Display();
        }
    }
}
