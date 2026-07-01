using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._05_Sorting_Strategies.SortStrategy
{
    public class AlphabeticalSort : ISortStrategy<string>
    {
        public IEnumerable<string> Sort(IEnumerable<string> items)
        {
            return items.OrderBy(x => x);
        }
    }
}
