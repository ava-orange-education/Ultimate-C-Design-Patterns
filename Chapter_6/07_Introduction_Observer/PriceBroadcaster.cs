using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._07_Introduction_Observer
{
    public class PriceBroadcaster : INotifier
    {
        private List<IListener> _listeners;

        public PriceBroadcaster()
        {
            _listeners = new List<IListener>();
        }

        public void Register(IListener listener)
        {
            _listeners.Add(listener);
        }

        public void Unregister(IListener listener)
        {
            _listeners.Remove(listener);
        }

        public void AlertListeners()
        {
            foreach (var listener in _listeners)
                listener.Refresh();
        }

        // Simulates a change in stock price
        public void SetPrice(decimal newPrice)
        {
            Console.WriteLine($"[Ticker] New stock price: ${newPrice}");
            AlertListeners();
        }
    }
}
