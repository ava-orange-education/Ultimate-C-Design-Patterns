using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Orchestrated_System_Interaction
{
    public class SmartThermostat : Device
    {
        public SmartThermostat(IDeviceMediator mediator) : base(mediator) { }

        public void Adjust()
        {
            Console.WriteLine("Thermostat: Adjusting temperature for occupancy.");
        }
    }
}
