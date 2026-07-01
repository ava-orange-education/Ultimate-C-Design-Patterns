using SolidPrinciples.SingleResponsibilityPrinciple.AuthManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._5_Real_World_Examples.SingleLoggerFactory
{
    public class SingleLoggerFactory
    {
        public static ILogger CreateLogger() => new ConsoleLogger();
    }
}
