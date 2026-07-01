using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._01_Introduction
{
    internal class BubbleSort_Test
    {
        [Fact]
        public void Sorter_ShouldUseStrategyToSort()
        {
            var strategy = new BubbleSort();
            var sorter = new Sorter(strategy);

            var result = sorter.Sort(new[] { 3, 1, 2 });

            Assert.Equal(new[] { 1, 2, 3 }, result);
        }
    }
}
