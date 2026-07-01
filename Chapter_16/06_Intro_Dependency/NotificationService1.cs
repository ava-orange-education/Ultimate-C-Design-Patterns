using SolidPrinciples.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._06_Intro_Dependency
{
    public class NotificationService1
    {
        private readonly IMessageSender _sender;

        public NotificationService1(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Notify(string message)
        {
            _sender.Send(message);
        }
    }
}
