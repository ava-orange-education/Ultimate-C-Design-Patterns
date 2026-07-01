using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._07_Introduction_Observer
{
    public class PriceSubscriber : IListener
    {
        private string _subscriberName;

        public PriceSubscriber(string name)
        {
            _subscriberName = name;
        }

        public void Refresh()
        {
            Console.WriteLine($"[{_subscriberName}] Received price update.");
        }
    }
}
