using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._04_PracticalExamples_Strategy.MovementStrategy
{
    public interface IMovementStrategy
    {
        void Move(string name);
    }

    public class AggressiveRush : IMovementStrategy
    {
        public void Move(string name)
        {
            Console.WriteLine($"{name} charges directly into the enemy ranks!");
        }
    }
}
