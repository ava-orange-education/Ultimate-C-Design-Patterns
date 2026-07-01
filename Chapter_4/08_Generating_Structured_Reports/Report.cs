using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._08_Generating_Structured_Reports
{
    public class Report
    {
        public string Title { get; }
        public string Content { get; }
        public string Footer { get; }

        private Report(Builder builder)
        {
            Title = builder.Title;
            Content = builder.Content;
            Footer = builder.Footer;
        }

        public class Builder
        {
            public string Title;
            public string Content;
            public string Footer;

            public Builder WithTitle(string title) { Title = title; return this; }
            public Builder WithContent(string content) { Content = content; return this; }
            public Builder WithFooter(string footer) { Footer = footer; return this; }
            public Report Build() => new Report(this);
        }
    }
}
