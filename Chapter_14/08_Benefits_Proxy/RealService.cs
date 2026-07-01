using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._08_Benefits_Proxy
{
    class RealService : IService
    {
        public void Execute(string command)
        {
            Console.WriteLine($"Command '{command}' executed.");
        }
    }
}
