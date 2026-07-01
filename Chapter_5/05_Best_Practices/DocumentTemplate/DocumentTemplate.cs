using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter_5._05_Best_Practices.DocumentTemplate
{
    class DocumentTemplate
    {
        public string Title { get; set; }
        public Formatting Style { get; set; }

        public DocumentTemplate(string title, Formatting style)
        {
            Title = title;
            Style = style;
        }

        public DocumentTemplate CloneShallow()
        {
            return new DocumentTemplate(this.Title, this.Style);  // SHALLOW COPY WARNING
        }

        public DocumentTemplate CloneDeep()
        {
            return new DocumentTemplate(this.Title, new Formatting(this.Style.Font, this.Style.Color));
        }
    }
}
