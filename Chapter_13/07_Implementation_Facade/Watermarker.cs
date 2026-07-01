using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._07_Implementation_Facade
{
    public class Watermarker
    {
        public void ApplyWatermark(string filePath)
        {
            Console.WriteLine($"Applying watermark to: {filePath}");
        }
    }
}
