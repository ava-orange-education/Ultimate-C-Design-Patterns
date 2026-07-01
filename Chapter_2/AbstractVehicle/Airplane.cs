using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.AbstractVehicle
{
    public class Airplane : Vehicle1
    {
        public override void Move()
        {
            Console.WriteLine("Flying through the sky.");
        }
    }
}
