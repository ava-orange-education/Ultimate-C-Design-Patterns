using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11._02_Implementation_Visitor
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public int ProjectsLed { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitManager(this);
        }

        public void PlanProject()
        {
            Console.WriteLine($"{Name} is planning a new project...");
        }
    }
}
