using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_02_Tooling
{
    //public class ExportService
    //{
    //    public void Export(string format, object data)
    //    {
    //        if (format == "PDF")
    //        {
    //            // PDF logic
    //        }
    //        else if (format == "Excel")
    //        {
    //            // Excel logic
    //        }
    //        else if (format == "CSV")
    //        {
    //            // CSV logic
    //        }
    //    }
    //}

    public class ExportService
    {
        private readonly Dictionary<string, IExportStrategy> _strategies;

        public ExportService(Dictionary<string, IExportStrategy> strategies)
        {
            _strategies = strategies;
        }

        public void Export(string format, object data)
        {
            if (_strategies.TryGetValue(format, out var strategy))
                strategy.Export(data);
        }
    }

}
