using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Products
{
    public class DigitalSubscription : IBuyable, ISubscribable
    {
        public void Buy()
        {
            Console.WriteLine("Purchased subscription.");
        }

        public void Subscribe()
        {
            Console.WriteLine("Subscribed to digital service.");
        }
    }
}
