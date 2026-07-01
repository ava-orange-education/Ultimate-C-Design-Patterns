using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_03_Patterns_and_DevOps
{
    public class DeploymentMonitor
    {
        private readonly List<IDeploymentObserver> _observers = new List<IDeploymentObserver>();

        public void Attach(IDeploymentObserver observer) => _observers.Add(observer);

        public void Notify(string status)
        {
            foreach (var observer in _observers)
                observer.Update(status);
        }

        public void StartDeployment()
        {
            Notify("Started");
            // Simulate deployment steps...
            Notify("Completed");
        }
    }
}
