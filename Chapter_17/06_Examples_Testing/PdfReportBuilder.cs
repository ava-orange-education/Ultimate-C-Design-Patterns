using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._06_Examples_Testing
{
    public class PdfReportBuilder : IReportBuilder
    {
        private readonly Report _report = new Report();

        public void BuildHeader() => _report.Header = "PDF Header";
        public void BuildBody() => _report.Body = "PDF Body";
        public void BuildFooter() => _report.Footer = "PDF Footer";

        public Report GetReport() => _report;
    }
}
