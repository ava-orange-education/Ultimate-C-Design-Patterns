using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._10_Examples_Notification_Systems
{
    public interface INotifier
    {
        void Register(IChannel1 channel);
        void Unregister(IChannel1 channel);
        void NotifyAll(string message);
    }
}
