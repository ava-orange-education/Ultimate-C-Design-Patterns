using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._04_PracticalExamples_Strategy.MovementStrategy
{
    public class Teleportation : IMovementStrategy
    {
        public void Move(string name)
        {
            Console.WriteLine($"{name} disappears and reappears behind enemy lines.");
        }
    }
}
