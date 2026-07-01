using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7._08_Example_Template.Web_Scrapers
{
    abstract class JobScraper
    {
        public void Scrape()
        {
            string html = Connect();
            string content = Extract(html);
            string normalized = Normalize(content);
            Save(normalized);
        }

        protected abstract string Connect();
        protected abstract string Extract(string html);
        protected abstract string Normalize(string rawData);

        protected void Save(string result)
        {
            Console.WriteLine($"Saving extracted job listings:\n{result}\n");
        }
    }
}
