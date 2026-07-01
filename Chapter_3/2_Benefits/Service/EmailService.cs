using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.Service
{
    public class EmailService : IService
    {
        public void Execute() => Console.WriteLine("Sending Email...");
    }
}
