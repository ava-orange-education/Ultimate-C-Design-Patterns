using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Products
{
    public class PhysicalProduct1 : IBuyable
    {
        public void Buy()
        {
            Console.WriteLine("Purchased physical item.");
        }
    }

}
