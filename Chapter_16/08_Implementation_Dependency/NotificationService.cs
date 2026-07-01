using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._08_Implementation_Dependency
{
    public class NotificationService
    {
        private readonly IMessageSender _sender;

        public NotificationService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Notify(string message)
        {
            _sender.Send(message);
        }
    }
}
