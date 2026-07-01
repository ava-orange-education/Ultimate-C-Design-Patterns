using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._06_Introduction_Template
{
    class FileProcessor : AbstractProcessor
    {
        protected override void FetchData()
        {
            Console.WriteLine("Reading data from file...");
        }

        protected override void OptionallyLog()
        {
            Console.WriteLine("Logging file read operation.");
        }
    }
}
