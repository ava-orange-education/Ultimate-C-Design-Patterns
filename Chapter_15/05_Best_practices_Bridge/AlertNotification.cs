using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    class AlertNotification : Notification
    {
        public AlertNotification(IMessageSender sender) : base(sender) { }

        public override void Send(string message)
        {
            Console.WriteLine("ALERT:");
            sender.SendMessage(message);
        }
    }
}
