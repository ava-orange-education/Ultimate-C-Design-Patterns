using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportGenerator
{
    // Step 3: Implement PDF Report
    public class PdfReport : ReportGenerator
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data for PDF report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as PDF...");
        }
    }
}
