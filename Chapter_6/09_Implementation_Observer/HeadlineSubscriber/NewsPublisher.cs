using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._09_Implementation_Observer.HeadlineSubscriber
{
    public class NewsPublisher : IObservable<string>
    {
        private readonly List<IObserver<string>> _subscribers = new List<IObserver<string>>();

        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!_subscribers.Contains(observer))
                _subscribers.Add(observer);

            return new Unsubscriber(_subscribers, observer);
        }

        public void PublishHeadline(string headline)
        {
            foreach (var observer in _subscribers)
                observer.OnNext(headline);
        }

        public void CloseFeed()
        {
            foreach (var observer in _subscribers)
                observer.OnCompleted();
            _subscribers.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>> _observers;
            private IObserver<string> _observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
