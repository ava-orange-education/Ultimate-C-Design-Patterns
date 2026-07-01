using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._09_Implementation_Observer.WeatherListener
{
    public interface IWeatherStation
    {
        void Register(IWeatherListener listener);
        void Unregister(IWeatherListener listener);
        void NotifyAll();
    }
}
