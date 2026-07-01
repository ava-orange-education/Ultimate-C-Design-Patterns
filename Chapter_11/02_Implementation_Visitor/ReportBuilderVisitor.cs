using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._02_Implementation_Visitor
{
    public class ReportBuilderVisitor : IVisitor
    {
        public void VisitDeveloper(Developer dev)
        {
            Console.WriteLine($"Developer Report - {dev.Name}: LOC written - {dev.LinesOfCode}");
        }

        public void VisitManager(Manager mgr)
        {
            Console.WriteLine($"Manager Report - {mgr.Name}: Projects led - {mgr.ProjectsLed}");
        }
    }
}
