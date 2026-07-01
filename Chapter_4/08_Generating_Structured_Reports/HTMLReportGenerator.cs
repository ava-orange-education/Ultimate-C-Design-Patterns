using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._08_Generating_Structured_Reports
{
    public class HTMLReportGenerator
    {
        public static string Generate(Report report)
        {
            return $"<html><head><title>{report.Title}</title></head>" +
                   $"<body><h1>{report.Title}</h1><p>{report.Content}</p>" +
                   $"<footer>{report.Footer}</footer></body></html>";
        }
    }
}
