using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.BattleStrategy
{
    public class AggressiveAttack : IBattleStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Charging into battle with full force!");
        }
    }
}
