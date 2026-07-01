using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template
{
    class DroneAI : EnemyAI
    {
        protected override void ScanArea()
        {
            Console.WriteLine("Drone activates motion sensors.");
        }

        protected override void Move()
        {
            Console.WriteLine("Drone hovers to target location.");
        }

        protected override void Act()
        {
            Console.WriteLine("Drone launches stun dart.");
        }
    }
}
