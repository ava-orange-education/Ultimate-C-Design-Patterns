using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template.Medical_Reporting
{
    class RadiologyReport : MedicalReportGenerator
    {
        protected override string CollectData()
        {
            Console.WriteLine("Collecting MRI scan results...");
            return "PatientName: John Doe\nScan: Clear.";
        }

        protected override void Export(string output)
        {
            Console.WriteLine("Exporting radiology PDF report:");
            Console.WriteLine(output);
        }
    }
}
