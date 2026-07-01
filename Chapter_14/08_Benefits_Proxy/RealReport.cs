using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._08_Benefits_Proxy
{
    class RealReport : IReport
    {
        private string reportName;

        public RealReport(string reportName)
        {
            this.reportName = reportName;
            Console.WriteLine($"Loading data for {reportName}...");
        }

        public void Generate()
        {
            Console.WriteLine($"Generating report: {reportName}");
        }
    }
}
