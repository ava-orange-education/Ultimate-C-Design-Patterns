using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._09_Implementation_Observer.HeadlineSubscriber
{
    public class HeadlineSubscriber : IObserver<string>
    {
        private readonly string _name;

        public HeadlineSubscriber(string name) => _name = name;

        public void OnNext(string value)
        {
            Console.WriteLine($"[{_name}] New headline: {value}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"[{_name}] Error occurred: {error.Message}");
        }

        public void OnCompleted()
        {
            Console.WriteLine($"[{_name}] News stream closed.");
        }
    }
}
