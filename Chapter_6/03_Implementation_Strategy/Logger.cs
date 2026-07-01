using Chapter_6._03_Implementation_Strategy.LogStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy
{
    public class Logger
    {
        private ILogStrategy _strategy;

        public Logger(ILogStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetLogger(ILogStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Log(string message)
        {
            _strategy.Log(message);
        }
    }
}
