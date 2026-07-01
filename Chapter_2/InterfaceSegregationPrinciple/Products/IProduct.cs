using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Products
{
    public interface IProduct
    {
        void Buy();
        void Subscribe(); // Not relevant for one-time purchases
    }
}
