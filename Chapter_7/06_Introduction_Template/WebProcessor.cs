using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._06_Introduction_Template
{
    class WebProcessor : AbstractProcessor
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data from web API...");
        }
        // OptionallyLog is inherited and does nothing
    }
}
