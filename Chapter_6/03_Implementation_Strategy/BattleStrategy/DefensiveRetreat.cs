using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._03_Implementation_Strategy.BattleStrategy
{
    public class DefensiveRetreat : IBattleStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Retreating strategically to avoid unnecessary losses.");
        }
    }
}
