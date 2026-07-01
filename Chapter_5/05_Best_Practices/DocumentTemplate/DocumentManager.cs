using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._05_Best_Practices.DocumentTemplate
{
    class DocumentManager
    {
        static void Main()
        {
            DocumentTemplate original = new DocumentTemplate("Business Report", new Formatting("Arial", "Black"));
            DocumentTemplate clone = original.CloneShallow();

            // Modifying the cloned object's formatting
            clone.Style.Font = "Times New Roman";

            Console.WriteLine($"Original Template Font: {original.Style.Font}");  // OOPS! The original also changed
            Console.WriteLine($"Cloned Template Font: {clone.Style.Font}");
        }
    }
}
