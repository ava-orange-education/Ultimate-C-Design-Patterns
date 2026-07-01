using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._05_Sorting_Strategies.SortStrategy
{
    public class Sorter<T>
    {
        private ISortStrategy<T> _strategy;

        public Sorter(ISortStrategy<T> strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ISortStrategy<T> strategy)
        {
            _strategy = strategy;
        }

        public IEnumerable<T> Sort(IEnumerable<T> items)
        {
            return _strategy.Sort(items);
        }
    }
}
