using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._04_Avoid_antipaterns
{
    public class Logger1
    {
        private readonly ILogWriter _writer;

        public Logger1(ILogWriter writer)
        {
            _writer = writer;
        }

        public void Log(string message)
        {
            _writer.Write(message);
        }
    }
}
