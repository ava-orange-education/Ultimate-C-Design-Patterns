using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportGenerator
{
    // Step 2: Implement CSV Report
    public class CsvReport : ReportGenerator
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data for CSV report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as CSV...");
        }
    }
}
