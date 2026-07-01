using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._03_Unit_Testing
{
    public class NotificationFactory
    {
        public static INotification Create(string type)
        {
            switch (type)
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SmsNotification();
                default:
                    throw new ArgumentException("Unknown type");
            }
        }
    }
}


