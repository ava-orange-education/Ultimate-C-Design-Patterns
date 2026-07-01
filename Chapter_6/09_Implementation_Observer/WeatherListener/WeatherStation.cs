using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._09_Implementation_Observer.WeatherListener
{
    public class WeatherStation : IWeatherStation
    {
        private readonly List<IWeatherListener> _listeners = new List<IWeatherListener>();
        private double _temperature;

        public void Register(IWeatherListener listener) => _listeners.Add(listener);
        public void Unregister(IWeatherListener listener) => _listeners.Remove(listener);

        public void SetTemperature(double newTemp)
        {
            _temperature = newTemp;
            NotifyAll();
        }

        public void NotifyAll()
        {
            foreach (var listener in _listeners)
            {
                listener.Update(_temperature);
            }
        }
    }
}
