using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._03_Unit_Testing
{
    internal class ConfigurationManager_Test
    {
        [Fact]
        public void Singleton_ShouldReturnSameInstance()
        {
            var first = ConfigurationManager.Instance;
            var second = ConfigurationManager.Instance;

            Assert.Same(first, second);
        }
    }
}
