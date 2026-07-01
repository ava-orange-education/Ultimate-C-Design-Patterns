using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._05_Best_practices_Mediator
{
    public class SoilSensor
    {
        private readonly IFarmMediator mediator;

        public SoilSensor(IFarmMediator mediator)
        {
            this.mediator = mediator;
        }

        public void DetectDrySoil()
        {
            Console.WriteLine("Soil Sensor: Dry soil detected.");
            mediator.TriggerEvent(this, "DrySoil");
        }
    }
}
