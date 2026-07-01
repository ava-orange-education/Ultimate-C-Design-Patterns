using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._03_Implementation_Adapter
{
    // The adapter that bridges the gap
    public class SmsAdapter : INotifier
    {
        private SmsService smsService = new SmsService();

        public override void Send(string message)
        {
            smsService.SendTextMessage(message);
        }
    }
}
