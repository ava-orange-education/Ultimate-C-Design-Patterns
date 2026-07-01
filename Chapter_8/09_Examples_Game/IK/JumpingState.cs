using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game
{
    class JumpingState : IKaiState
    {
        public void Handle(KaiContext context)
        {
            Console.WriteLine("Kai leaps over the trap...");

            context.State = new IdleState();
        }
    }
}
