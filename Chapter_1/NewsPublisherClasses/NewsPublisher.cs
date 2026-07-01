using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.NewsPublisherClasses
{
    public class NewsPublisher
    {
        private List<IObserver> _observers = new();

        public void Subscribe(IObserver observer) => _observers.Add(observer);
        public void Notify(string news)
        {
            foreach (var observer in _observers)
                observer.Update(news);
        }
    }
}
