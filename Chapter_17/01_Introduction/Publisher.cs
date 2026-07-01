using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._01_Introduction
{
    public class Publisher
    {
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber) => _subscribers.Add(subscriber);

        public void Notify(string message)
        {
            foreach (var sub in _subscribers)
            {
                sub.Update(message);
            }
        }
    }
}
