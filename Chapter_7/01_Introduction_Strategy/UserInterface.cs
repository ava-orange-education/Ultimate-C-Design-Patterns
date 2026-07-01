using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._01_Introduction_Strategy
{
    // Client
    class UserInterface
    {
        static void Main()
        {
            SmartDevice lamp = new SmartDevice();
            ActionCommand turnOn = new TurnOnDeviceCommand(lamp);

            TaskInvoker controller = new TaskInvoker();
            controller.SetCommand(turnOn);

            controller.Run();     // Device is now ON.
            controller.Cancel();  // Device is now OFF.
        }
    }
}
