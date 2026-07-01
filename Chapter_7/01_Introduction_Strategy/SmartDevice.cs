using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._01_Introduction_Strategy
{
    // Receiver
    class SmartDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Device is now ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Device is now OFF.");
        }
    }
}
