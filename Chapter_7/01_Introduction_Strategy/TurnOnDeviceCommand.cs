using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._01_Introduction_Strategy
{
    // Concrete command
    class TurnOnDeviceCommand : ActionCommand
    {
        private SmartDevice device;

        public TurnOnDeviceCommand(SmartDevice device)
        {
            this.device = device;
        }

        public override void Execute()
        {
            device.TurnOn();
        }

        public override void Undo()
        {
            device.TurnOff();
        }
    }
}
