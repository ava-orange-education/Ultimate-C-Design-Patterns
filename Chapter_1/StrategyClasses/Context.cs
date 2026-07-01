using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.StrategyClasses
{
    // Context Class
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy) => _strategy = strategy;
        public void ExecuteStrategy() => _strategy.Execute();
    }
}
