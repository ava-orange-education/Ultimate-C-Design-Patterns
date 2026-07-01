using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._01_Introduction_Madiator
{
    class CoffeeMachine : Device
    {
        public CoffeeMachine(MessageBroker broker) : base(broker) { }

        public void ReceiveCommand(string info)
        {
            Console.WriteLine($"Coffee Machine brewing due to: {info}");
        }

        public void TriggerBrew(string reason)
        {
            broker.Relay(reason, this);
        }
    }
}
