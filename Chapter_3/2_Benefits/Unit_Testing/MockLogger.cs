using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._2_Benefits.Unit_Testing
{
    public class MockLogger : Logger.Logger
    {
        public override void Log(string message) => Console.WriteLine($"Mock Log: {message}");
    }
}
