using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class ImageFunctionWithObservers
    {
        private readonly List<IProcessingObserver> _observers = new List<IProcessingObserver>();

        public void Attach(IProcessingObserver observer) => _observers.Add(observer);

        public async Task RunAsync(string imageId)
        {
            // Process image...

            foreach (var observer in _observers)
            {
                await observer.NotifyAsync(imageId);
            }
        }
    }
}
