using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.FastUnit
{
    public class FastUnit
    {
        private Action _battleAction;

        public FastUnit(Action action)
        {
            _battleAction = action;
        }

        public void SetAction(Action newAction)
        {
            _battleAction = newAction;
        }

        public void Act()
        {
            _battleAction?.Invoke();
        }
    }
}
