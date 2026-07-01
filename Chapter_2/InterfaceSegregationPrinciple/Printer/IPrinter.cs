using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Printer
{
    public interface IPrinter
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
    }
}
