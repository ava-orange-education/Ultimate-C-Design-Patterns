using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosedPrinciple.NotificationFactory
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            switch (type)
            {
                case "Email":
                    return new EmailNotification();
                case "SMS":
                    return new SmsNotification();
                default:
                    throw new Exception("Invalid notification type");
            }
        }
    }
}
