using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._05_Sorting_Strategies.SortStrategy
{
    public class PriceSort : ISortStrategy<Product>
    {
        public IEnumerable<Product> Sort(IEnumerable<Product> items)
        {
            return items.OrderBy(p => p.Price);
        }
    }
}
