using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportGenerator
{
    // Step 1: Define an abstract class for report generation
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            LoadData();
            FormatData();
            Export();
        }

        protected abstract void LoadData();
        protected abstract void FormatData();
        protected virtual void Export()
        {
            Console.WriteLine("Exporting report...");
        }
    }
}
