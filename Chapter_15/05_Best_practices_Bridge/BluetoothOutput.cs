using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    class BluetoothOutput : IOutputDevice
    {
        public void PlaySound(string fileName)
        {
            Console.WriteLine($"Streaming '{fileName}' via Bluetooth.");
        }
    }
}
