using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game
{
    class IdleState : IKaiState
    {
        public void Handle(KaiContext context)
        {
            Console.WriteLine("Kai is standing still, surveying the horizon...");

            if (context.IsEnemyNearby())
            {
                context.State = new AttackingState();
            }
            else if (context.ShouldRun())
            {
                context.State = new RunningState();
            }
        }
    }
}
