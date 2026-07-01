using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Products
{
    public class PhysicalProduct : IProduct
    {
        public void Buy()
        {
            Console.WriteLine("Purchased physical item.");
        }

        public void Subscribe()
        {
            throw new NotImplementedException("Cannot subscribe to a physical product.");
        }
    }
}
