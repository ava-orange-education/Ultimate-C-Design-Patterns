using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._10_Examples_Notification_Systems
{
    public class UserNotifier : INotifier
    {
        private readonly List<IChannel1> _channels = new List<IChannel1>();

        public void Register(IChannel1 channel) => _channels.Add(channel);
        public void Unregister(IChannel1 channel) => _channels.Remove(channel);

        public void NotifyAll(string message)
        {
            foreach (var channel in _channels)
                channel.Send(message);
        }
    }

}
