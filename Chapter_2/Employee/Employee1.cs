using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Employee
{
    public abstract class Employee1
    {
        public string Name { get; set; }

        public void LogWorkHours()
        {
            Console.WriteLine($"{Name} logs work hours.");
        }

        public abstract void Work();
    }

}
