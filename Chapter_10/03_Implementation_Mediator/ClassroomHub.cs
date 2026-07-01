using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._03_Implementation_Mediator
{
    public class ClassroomHub : IMediator
    {
        public SmartProjector Projector { get; set; }
        public SmartLights Lights { get; set; }
        public ClimateControl AC { get; set; }

        public void Notify(object sender, string ev)
        {
            if (ev == "PresentationStarted")
            {
                Lights.Dim();
                AC.CoolRoom();
            }
            else if (ev == "PresentationEnded")
            {
                Lights.Brighten();
                AC.StandbyMode();
            }
            else if (ev == "LowAmbientLight")
            {
                Projector.AdjustBrightness();
            }
        }
    }
}
