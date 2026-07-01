using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._06_Introduction_State
{
    class RunningMode : IMode
    {
        public override void Handle(MachineContext context)
        {
            Console.WriteLine("Machine was running. Shutting down...");
            context.Mode = new IdleMode();
        }
    }
}
