using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.NotificationService
{
    public class NotificationServiceFactory
    {
        public static INotificationService CreateService(string type)
        {
            switch (type)
            {
                case "Email":
                    return new EmailNotificationService();
                case "SMS":
                    return new SmsNotificationService();
                default:
                    throw new ArgumentException("Unknown service type");
            }
        }
    }
}
