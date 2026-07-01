using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._01_Introduction_Strategy
{
    // The context that uses a movement strategy
    public class Navigator
    {
        public IMovementMode MovementMode { get; set; }

        public Navigator(IMovementMode movement)
        {
            MovementMode = movement;
        }

        public void Navigate()
        {
            Console.WriteLine("Navigator starting up!");
            MovementMode.Move();
        }
    }
}
