using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Printer
{
    public class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }

        public void Scan(string content)
        {
            throw new NotImplementedException("BasicPrinter cannot scan!");
        }

        public void Fax(string content)
        {
            throw new NotImplementedException("BasicPrinter cannot fax!");
        }
    }
}
