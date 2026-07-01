using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._01_Introduction_Madiator
{
    abstract class Device
    {
        protected MessageBroker broker;

        public Device(MessageBroker broker)
        {
            this.broker = broker;
        }
    }
}
