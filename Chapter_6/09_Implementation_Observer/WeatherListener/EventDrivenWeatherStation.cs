using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._09_Implementation_Observer.WeatherListener
{
    public class EventDrivenWeatherStation
    {
        public delegate void TemperatureChangedHandler(double temp);
        public event TemperatureChangedHandler TemperatureChanged;

        private double _temperature;

        public void SetTemperature(double newTemp)
        {
            _temperature = newTemp;
            TemperatureChanged?.Invoke(_temperature);
        }
    }
}
