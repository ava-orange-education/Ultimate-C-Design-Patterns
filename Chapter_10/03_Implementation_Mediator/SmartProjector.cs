using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._03_Implementation_Mediator
{
    public class SmartProjector
    {
        private IMediator mediator;

        public SmartProjector(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void StartPresentation()
        {
            Console.WriteLine("Projector: Starting presentation.");
            mediator.Notify(this, "PresentationStarted");
        }

        public void EndPresentation()
        {
            Console.WriteLine("Projector: Ending presentation.");
            mediator.Notify(this, "PresentationEnded");
        }

        public void AdjustBrightness()
        {
            Console.WriteLine("Projector: Adjusting brightness due to low ambient light.");
        }
    }
}
