using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._07_Implementation_Facade
{
    public class VideoDecoder
    {
        public void Decode(string filePath)
        {
            Console.WriteLine($"Decoding video file: {filePath}");
        }
    }
}
