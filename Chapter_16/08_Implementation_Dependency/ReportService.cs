using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._08_Implementation_Dependency
{
    public class ReportService
    {
        public ILogger Logger { get; set; }

        public void GenerateReport()
        {
            // Do some work...
            Logger?.Log("Report generated.");
        }
    }
}
