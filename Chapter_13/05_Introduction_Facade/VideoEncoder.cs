using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._05_Introduction_Facade
{
    public class VideoEncoder
    {
        public void EncodeVideo(string file)
        {
            Console.WriteLine($"Encoding video in {file}");
        }
    }
}
