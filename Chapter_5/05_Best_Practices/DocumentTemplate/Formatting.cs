using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5._05_Best_Practices.DocumentTemplate
{
    class Formatting
    {
        public string Font { get; set; }
        public string Color { get; set; }

        public Formatting(string font, string color)
        {
            Font = font;
            Color = color;
        }
    }
}
