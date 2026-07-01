using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.NotificationService
{
    public class NotificationService
    {
        public void SendNotification(string message)
        {
            // Send email
            Console.WriteLine($"Email: {message}");

            // Send SMS
            Console.WriteLine($"SMS: {message}");

            // Send Push Notification
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
