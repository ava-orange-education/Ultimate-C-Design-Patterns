using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Orchestrated_System_Interaction
{
    public class SmartLights : Device
    {
        public SmartLights(IDeviceMediator mediator) : base(mediator) { }

        public void On()
        {
            Console.WriteLine("Lights: Turning on.");
        }

        public void Off()
        {
            Console.WriteLine("Lights: Turning off.");
        }
    }
}
