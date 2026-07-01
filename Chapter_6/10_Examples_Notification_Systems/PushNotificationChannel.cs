using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._10_Examples_Notification_Systems
{
    public class PushNotificationChannel : IChannel1
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Push] Sending push notification: {message}");
        }
    }
}
