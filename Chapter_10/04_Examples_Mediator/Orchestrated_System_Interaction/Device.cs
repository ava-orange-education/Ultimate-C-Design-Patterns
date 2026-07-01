using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Orchestrated_System_Interaction
{
    public abstract class Device
    {
        protected readonly IDeviceMediator mediator;

        public Device(IDeviceMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
