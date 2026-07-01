using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.NotificationService
{
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message) =>
            Console.WriteLine($"SMS Sent: {message}");
    }
}
