using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._03_Implementation_Mediator
{
    public class SmartLights
    {
        private IMediator mediator;

        public SmartLights(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Dim()
        {
            Console.WriteLine("Lights: Dimming for presentation.");
        }

        public void Brighten()
        {
            Console.WriteLine("Lights: Brightening after presentation.");
        }

        public void DetectLowAmbientLight()
        {
            Console.WriteLine("Lights: Detected low ambient light.");
            mediator.Notify(this, "LowAmbientLight");
        }
    }
}
