using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._03_Implementation_Mediator
{
    public class ClimateControl
    {
        private IMediator mediator;

        public ClimateControl(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void CoolRoom()
        {
            Console.WriteLine("AC: Cooling room for presentation.");
        }

        public void StandbyMode()
        {
            Console.WriteLine("AC: Switching to standby mode.");
        }
    }
}
