using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._04_PracticalExamples_Strategy.AttackStrategy
{
    public class RangedVolley : IAttackStrategy
    {
        public void Attack(string name)
        {
            Console.WriteLine($"{name} fires a volley of arrows from afar.");
        }
    }
}
