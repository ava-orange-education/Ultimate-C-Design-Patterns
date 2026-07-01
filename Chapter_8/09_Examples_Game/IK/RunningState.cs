using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game
{
    class RunningState : IKaiState
    {
        public void Handle(KaiContext context)
        {
            Console.WriteLine("Kai is sprinting through the forest!");

            context.Energy -= 10;

            if (context.Energy <= 0)
            {
                context.State = new TiredState();
            }
            else if (context.ShouldJump())
            {
                context.State = new JumpingState();
            }
        }
    }
}
