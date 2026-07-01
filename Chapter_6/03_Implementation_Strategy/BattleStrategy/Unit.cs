using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.BattleStrategy
{
    public class Unit
    {
        private IBattleStrategy _strategy;

        public Unit(IBattleStrategy initialStrategy)
        {
            _strategy = initialStrategy;
        }

        public void SetStrategy(IBattleStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Engage()
        {
            _strategy.Execute();
        }
    }
}
