using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Printer
{
    public class BasicPrinter1 : IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }
    }
}
