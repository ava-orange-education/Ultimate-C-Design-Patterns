using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._09_Implementation_Observer.WeatherListener
{
    public class ConsoleDisplay : IWeatherListener
    {
        private readonly string _name;

        public ConsoleDisplay(string name) => _name = name;

        public void Update(double temperature)
        {
            Console.WriteLine($"[{_name}] Current temperature: {temperature}°C");
        }
    }
}
