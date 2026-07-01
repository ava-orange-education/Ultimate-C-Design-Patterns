using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._01_Introduction_Madiator
{
    class HomeHub : MessageBroker
    {
        public Thermostat Thermostat { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }

        public override void Relay(string instruction, Device sender)
        {
            if (sender == Thermostat)
                CoffeeMachine.ReceiveCommand($"Room temp alert: {instruction}");
            else
                Thermostat.ReceiveCommand($"Triggered by CoffeeMachine: {instruction}");
        }
    }
}
