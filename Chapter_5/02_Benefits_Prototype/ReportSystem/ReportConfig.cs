using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._02_Benefits_Prototype.ReportSystem
{
    class ReportConfig
    {
        public string Currency { get; set; }
        public bool IncludeGraphs { get; set; }

        public ReportConfig(string currency, bool includeGraphs)
        {
            Currency = currency;
            IncludeGraphs = includeGraphs;
        }

        public ReportConfig DeepCopy()
        {
            return new ReportConfig(this.Currency, this.IncludeGraphs);
        }
    }
}
