using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class NotificationService
    {
        private readonly NotificationFactory _factory;

        public NotificationService(NotificationFactory factory)
        {
            _factory = factory;
        }

        public void Send(string message)
        {
            var notification = _factory.CreateNotification();
            notification.Send(message);
        }
    }
}
