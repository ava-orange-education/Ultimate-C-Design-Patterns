using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SortStrategy
{
    // Step 1: Define an interface for sorting strategies
    public interface ISortStrategy
    {
        void Sort(int[] array);
    }
}
