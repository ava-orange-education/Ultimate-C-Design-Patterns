using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    abstract class Notification
    {
        protected IMessageSender sender;

        public Notification(IMessageSender sender)
        {
            this.sender = sender;
        }

        public abstract void Send(string message);
    }
}
