using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._03_Practical_examples_Antipatterns.WinForm_Example
{
    public class ExportService
    {
        public void Export(IEnumerable<string> data, string path)
        {
            File.WriteAllLines(path, data);
        }
    }

}
