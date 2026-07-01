using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class NoiseFilter : ISensorProcessor
    {
        private readonly ISensorProcessor _inner;

        public NoiseFilter(ISensorProcessor inner)
        {
            _inner = inner;
        }

        public double Process(double input)
        {
            var filtered = input < 0.05 ? 0 : input;
            return _inner.Process(filtered);
        }
    }
}
