using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Printer
{
    public class MultiFunctionPrinter : IPrint, IScan, IFax
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"Scanning: {content}");
        }

        public void Fax(string content)
        {
            Console.WriteLine($"Faxing: {content}");
        }
    }
}
