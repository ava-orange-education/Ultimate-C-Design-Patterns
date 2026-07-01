using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.Orchestrated_System_Interaction
{
    public class SmartDoor : Device
    {
        public SmartDoor(IDeviceMediator mediator) : base(mediator) { }

        public void Enter()
        {
            Console.WriteLine("Smart Door: Person entered.");
            mediator.Notify(this, "Entry");
        }
    }
}
