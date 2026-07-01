using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._01_Introduction
{
    public class BubbleSort : ISortingStrategy
    {
        public int[] Sort(int[] data)
        {
            // Simplified bubble sort
            var result = (int[])data.Clone();
            Array.Sort(result); // Pretend this is bubble sort for brevity
            return result;
        }
    }
}
