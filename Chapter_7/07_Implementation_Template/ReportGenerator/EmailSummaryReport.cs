using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._07_Implementation_Template.ReportGenerator
{
    class EmailSummaryReport : ReportGenerator
    {
        protected override string FetchData()
        {
            Console.WriteLine("Gathering daily performance metrics...");
            return "Active Users: 1,200\nNew Signups: 230\nIncidents: 1";
        }

        protected override string FormatData(string rawData)
        {
            Console.WriteLine("Formatting for email body...");
            return $"🚀 Daily Summary\n\n{rawData}\n";
        }

        protected override void Export(string formattedContent)
        {
            Console.WriteLine("Sending email to: team@company.com");
            Console.WriteLine($"Email Body:\n{formattedContent}\n");
        }
    }
}
