using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._02_Implementation_Visitor
{
    public class CompensationCalculatorVisitor : IVisitor
    {
        public void VisitDeveloper(Developer dev)
        {
            int salary = 3000 + dev.LinesOfCode / 10;
            Console.WriteLine($"Calculated salary for Developer {dev.Name}: ${salary}");
        }

        public void VisitManager(Manager mgr)
        {
            int salary = 4000 + mgr.ProjectsLed * 500;
            Console.WriteLine($"Calculated salary for Manager {mgr.Name}: ${salary}");
        }
    }
}
