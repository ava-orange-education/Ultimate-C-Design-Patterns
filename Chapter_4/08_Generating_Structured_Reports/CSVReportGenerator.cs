using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._08_Generating_Structured_Reports
{
    public class CSVReportGenerator
    {
        public static void Generate(Report report, string filePath)
        {
            File.WriteAllText(filePath, $"{report.Title}\n{report.Content}\n{report.Footer}");
        }
    }
}
