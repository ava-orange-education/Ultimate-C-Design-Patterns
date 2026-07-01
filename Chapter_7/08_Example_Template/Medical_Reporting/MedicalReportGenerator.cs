using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template.Medical_Reporting
{
    abstract class MedicalReportGenerator
    {
        public void GenerateReport()
        {
            var raw = CollectData();
            var anonymized = AnonymizeData(raw);
            Export(anonymized);
        }

        protected abstract string CollectData();

        protected virtual string AnonymizeData(string input)
        {
            Console.WriteLine("Anonymizing patient identifiers...");
            return input.Replace("PatientName", "REDACTED");
        }

        protected abstract void Export(string output);
    }
}
