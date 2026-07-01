using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._01_Introduction_Strategy
{
    // A concrete strategy: spiral pattern
    public class SpiralMovement : IMovementMode
    {
        public void Move()
        {
            Console.WriteLine("Sweeping the room in a spiral...");
        }
    }
}
