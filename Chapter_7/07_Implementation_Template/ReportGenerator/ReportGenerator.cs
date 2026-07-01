using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._07_Implementation_Template.ReportGenerator
{
    abstract class ReportGenerator
    {
        public void Generate()
        {
            var rawData = FetchData();
            var formatted = FormatData(rawData);
            Export(formatted);
        }

        protected abstract string FetchData();
        protected abstract string FormatData(string rawData);
        protected abstract void Export(string formattedContent);
    }
}
