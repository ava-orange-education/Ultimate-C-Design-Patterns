using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._07_Benefits_dependency
{
    public class ReportGenerator
    {
        private readonly IDataFetcher _fetcher;
        private readonly IReportBuilder _builder;
        private readonly IFileWriter _writer;

        public ReportGenerator(IDataFetcher fetcher, IReportBuilder builder, IFileWriter writer)
        {
            _fetcher = fetcher;
            _builder = builder;
            _writer = writer;
        }

        public void Generate()
        {
            var data = _fetcher.Fetch();
            var report = _builder.Build(data);
            _writer.Write("report.txt", report);
        }
    }
}
