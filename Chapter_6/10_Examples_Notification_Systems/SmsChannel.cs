using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._10_Examples_Notification_Systems
{
    public class SmsChannel : IChannel1
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS] Sending SMS: {message}");
        }
    }
}
