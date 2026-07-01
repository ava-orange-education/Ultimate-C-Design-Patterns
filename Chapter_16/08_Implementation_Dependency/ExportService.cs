using Chapter_16._07_Benefits_dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._08_Implementation_Dependency
{
    public class ExportService
    {
        public void Export(string data, IFileWriter writer)
        {
            writer.Write("export.txt", data);
        }
    }
}
