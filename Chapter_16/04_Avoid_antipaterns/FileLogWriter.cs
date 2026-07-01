using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._04_Avoid_antipaterns
{
    public class FileLogWriter : ILogWriter
    {
        public void Write(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}
