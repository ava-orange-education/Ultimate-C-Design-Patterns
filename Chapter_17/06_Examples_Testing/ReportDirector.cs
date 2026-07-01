using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._06_Examples_Testing
{
    public class ReportDirector
    {
        public Report Construct(IReportBuilder builder)
        {
            builder.BuildHeader();
            builder.BuildBody();
            builder.BuildFooter();
            return builder.GetReport();
        }
    }
}
