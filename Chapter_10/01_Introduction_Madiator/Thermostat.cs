using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._01_Introduction_Madiator
{
    class Thermostat : Device
    {
        public Thermostat(MessageBroker broker) : base(broker) { }

        public void AlertTemperature(string info)
        {
            broker.Relay(info, this);
        }

        public void ReceiveCommand(string info)
        {
            Console.WriteLine($"Thermostat received command: {info}");
        }
    }
}
