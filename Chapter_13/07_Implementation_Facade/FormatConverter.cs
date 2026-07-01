using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._07_Implementation_Facade
{
    public class FormatConverter
    {
        public void ConvertToMp4(string filePath)
        {
            Console.WriteLine($"Converting {filePath} to MP4 format");
        }
    }
}
