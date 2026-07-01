using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Notification
{
    public interface INotification
    {
        void Send(string message);
        void Schedule(DateTime time);
        void RetryFailedMessages();
        void SaveToDatabase();
        void FormatMessage();
        void ValidateMessage();
    }
}
