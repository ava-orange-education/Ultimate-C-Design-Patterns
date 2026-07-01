using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._01_Introduction_Strategy
{
    // Another concrete strategy: hugging the walls
    public class WallFollowingMovement : IMovementMode
    {
        public void Move()
        {
            Console.WriteLine("Following along the walls like a shadow...");
        }
    }
}
