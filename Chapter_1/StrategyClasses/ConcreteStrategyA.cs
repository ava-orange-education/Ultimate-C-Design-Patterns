using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.StrategyClasses
{
    // Concrete Strategies
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing Strategy A");
    }
}
