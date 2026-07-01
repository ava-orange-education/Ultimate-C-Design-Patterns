using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._01_Introduction
{
    public interface ISortingStrategy
    {
        int[] Sort(int[] data);
    }
}
