using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._08_Benefits_Proxy
{
    class LazyReportProxy : IReport
    {
        private RealReport report;
        private string reportName;

        public LazyReportProxy(string reportName)
        {
            this.reportName = reportName;
        }

        public void Generate()
        {
            if (report == null)
            {
                Console.WriteLine("Initializing report...");
                report = new RealReport(reportName);
            }

            report.Generate();
        }
    }
}
