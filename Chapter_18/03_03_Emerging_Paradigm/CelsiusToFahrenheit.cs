using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class CelsiusToFahrenheit : ISensorProcessor
    {
        public double Process(double input)
        {
            return input * 9 / 5 + 32;
        }
    }
}
