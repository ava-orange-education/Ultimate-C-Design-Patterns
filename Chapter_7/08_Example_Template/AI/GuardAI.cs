using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template
{
    class GuardAI : EnemyAI
    {
        protected override void ScanArea()
        {
            Console.WriteLine("Guard scans the hallway.");
        }

        protected override void Move()
        {
            Console.WriteLine("Guard walks toward the sound.");
        }

        protected override void Act()
        {
            Console.WriteLine("Guard raises weapon and yells.");
        }
    }
}
