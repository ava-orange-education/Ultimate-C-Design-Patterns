using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._02_Implementation_Visitor
{
    public class Developer : IEmployee
    {
        public string Name { get; set; }
        public int LinesOfCode { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitDeveloper(this);
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code...");
        }
    }
}
