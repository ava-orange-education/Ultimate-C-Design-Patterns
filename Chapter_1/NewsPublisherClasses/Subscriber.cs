using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.NewsPublisherClasses
{
    public class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name) => _name = name;

        public void Update(string news) => Console.WriteLine($"{_name} received news: {news}");
    }
}
