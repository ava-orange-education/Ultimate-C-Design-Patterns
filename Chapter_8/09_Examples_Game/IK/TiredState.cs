using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game
{
    class TiredState : IKaiState
    {
        public void Handle(KaiContext context)
        {
            Console.WriteLine("Kai is catching his breath...");

            context.Energy += 15;

            if (context.Energy >= 100)
            {
                context.State = new IdleState();
            }
        }
    }
}
