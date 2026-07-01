using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.StrategyClasses
{
    public class ConcreteStrategyB : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing Strategy B");
    }
}
