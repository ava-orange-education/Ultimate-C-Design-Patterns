using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Orchestrated_System_Interaction
{
    public class BuildingMediator : IDeviceMediator
    {
        public SmartDoor Door { get; set; }
        public SmartLights Lights { get; set; }
        public SmartThermostat Thermostat { get; set; }

        public void Notify(Device sender, string action)
        {
            if (action == "Entry")
            {
                Lights.On();
                Thermostat.Adjust();
            }
        }
    }
}
