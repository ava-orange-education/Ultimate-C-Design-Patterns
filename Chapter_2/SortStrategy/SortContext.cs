using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SortStrategy
{
    // Step 4: Context class that interacts with different sorting algorithms
    public class SortContext
    {
        private ISortStrategy _strategy;

        public SortContext(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteSort(int[] array)
        {
            _strategy.Sort(array);
        }
    }
}
