using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_01_Pattern_Evolution
{
    public interface IPaymentStrategy
    {
        Task<bool> ProcessAsync(decimal amount);
    }
}
