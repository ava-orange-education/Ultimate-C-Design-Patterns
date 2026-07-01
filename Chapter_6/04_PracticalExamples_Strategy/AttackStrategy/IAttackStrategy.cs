using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._04_PracticalExamples_Strategy.AttackStrategy
{
    public interface IAttackStrategy
    {
        void Attack(string name);
    }
}
