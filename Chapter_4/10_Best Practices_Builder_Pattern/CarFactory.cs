using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._10_Best_Practices_Builder_Pattern
{
    public class CarFactory
    {
        public static Car CreateSportsCar()
        {
            return new Car("V8 Engine", "Red Paint", "Sport Seats");
        }

        public static Car CreateEconomyCar()
        {
            return new Car("Hybrid Engine", "Blue Paint", "Standard Seats");
        }
    }
}
