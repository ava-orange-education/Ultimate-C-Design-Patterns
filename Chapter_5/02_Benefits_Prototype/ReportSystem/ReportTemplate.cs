using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._02_Benefits_Prototype.ReportSystem
{
    class ReportTemplate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ReportConfig Config { get; set; }

        public ReportTemplate(string title, string description, ReportConfig config)
        {
            Title = title;
            Description = description;
            Config = config;
        }

        public ReportTemplate Clone()
        {
            return new ReportTemplate(this.Title, this.Description, this.Config.DeepCopy());
        }
    }
}
