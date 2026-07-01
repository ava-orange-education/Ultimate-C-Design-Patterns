using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._01_Introduction
{
    public class Sorter
    {
        private ISortingStrategy _strategy;

        public Sorter(ISortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public int[] Sort(int[] data) => _strategy.Sort(data);
    }
}
