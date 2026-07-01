using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._4_Use_Cases.NotificationService
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}
