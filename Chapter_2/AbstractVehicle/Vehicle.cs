using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.AbstractVehicle
{
    public abstract class Vehicle
    {
        public string Model { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"{Model} engine started.");
        }

        public abstract void Drive();
    }
}
