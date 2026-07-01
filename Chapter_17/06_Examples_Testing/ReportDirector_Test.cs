using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._06_Examples_Testing
{
    internal class ReportDirector_Test
    {
        [Fact]
        public void Builder_ShouldConstructCompleteReport()
        {
            var builder = new PdfReportBuilder();
            var director = new ReportDirector();

            var report = director.Construct(builder);

            Assert.Equal("PDF Header", report.Header);
            Assert.Equal("PDF Body", report.Body);
            Assert.Equal("PDF Footer", report.Footer);
        }
    }
}
