using SolidPrinciples.ReportGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._5_Real_World_Examples.ReportGeneratorFactory
{
    public class ReportGeneratorFactory
    {
        public static IReportGenerator CreateGenerator(string type)
        {
            IReportGenerator generator;

            switch (type)
            {
                case "PDF":
                    generator = new PdfReportGenerator();
                    break;
                case "Excel":
                    generator = new ExcelReportGenerator();
                    break;
                default:
                    throw new ArgumentException("Invalid report type");
            }

            return generator;
        }
    }
}
