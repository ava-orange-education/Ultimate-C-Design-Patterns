using System;
using System.Collections.Generic;

namespace Chapter_17._02_Best_Practices
{
    public class Cart
    {
        internal List<Product> Items { set; get; }
        internal void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}