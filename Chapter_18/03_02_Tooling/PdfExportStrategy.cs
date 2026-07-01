using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_02_Tooling
{
    public class PdfExportStrategy : IExportStrategy
    {
        public void Export(object data)
        {
            Console.WriteLine("Exporting to PDF...");
        }
    }
}
