using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._02_Implementation_Visitor
{
    class CompanyApp
    {
        static void Main()
        {
            var team = new List<IEmployee>
        {
            new Developer { Name = "Eva", LinesOfCode = 15000 },
            new Manager { Name = "Liam", ProjectsLed = 3 }
        };

            var compensationVisitor = new CompensationCalculatorVisitor();
            var reportVisitor = new ReportBuilderVisitor();

            foreach (var member in team)
            {
                member.Accept(compensationVisitor);
                member.Accept(reportVisitor);
            }
        }
    }
}
