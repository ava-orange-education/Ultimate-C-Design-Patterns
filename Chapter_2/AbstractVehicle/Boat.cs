using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.AbstractVehicle
{
    public class Boat : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Boat is sailing.");
        }
    }
}
