using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple.NotificationService
{
    public interface INotification
    {
        void Send(string message);
    }
}
