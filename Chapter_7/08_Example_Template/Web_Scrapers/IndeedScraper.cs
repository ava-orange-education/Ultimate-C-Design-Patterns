using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template.Web_Scrapers
{
    class IndeedScraper : JobScraper
    {
        protected override string Connect()
        {
            Console.WriteLine("Connecting to Indeed...");
            return "<html><div class='job'>C# Dev</div></html>";
        }

        protected override string Extract(string html)
        {
            Console.WriteLine("Extracting jobs from Indeed...");
            return "C# Dev";
        }

        protected override string Normalize(string rawData)
        {
            Console.WriteLine("Normalizing job title...");
            return $"Position: {rawData.ToUpper()}";
        }
    }
}
