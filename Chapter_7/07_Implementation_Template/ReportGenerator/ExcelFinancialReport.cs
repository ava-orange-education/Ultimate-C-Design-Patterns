using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._07_Implementation_Template.ReportGenerator
{
    class ExcelFinancialReport : ReportGenerator
    {
        protected override string FetchData()
        {
            Console.WriteLine("Retrieving monthly financial data...");
            return "Month,Revenue,Expenses\nApril,10000,6000\nMay,12000,7200";
        }

        protected override string FormatData(string rawData)
        {
            Console.WriteLine("Converting to Excel-compatible markup...");
            return $"<Workbook><Data>{rawData}</Data></Workbook>";
        }

        protected override void Export(string formattedContent)
        {
            Console.WriteLine("Saving as Excel file: /exports/monthly_financial.xlsx");
            Console.WriteLine($"Saved content:\n{formattedContent}\n");
        }
    }
}
