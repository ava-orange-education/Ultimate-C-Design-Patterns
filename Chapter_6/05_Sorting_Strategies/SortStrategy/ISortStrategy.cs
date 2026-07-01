using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._05_Sorting_Strategies.SortStrategy
{
    public interface ISortStrategy<T>
    {
        IEnumerable<T> Sort(IEnumerable<T> items);
    }
}
