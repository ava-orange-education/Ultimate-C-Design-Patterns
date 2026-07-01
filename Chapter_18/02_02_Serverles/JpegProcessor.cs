using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class JpegProcessor : IImageProcessorStrategy
    {
        public async Task ProcessAsync(Stream imageStream)
        {
            // Resize and compress JPEG
            Console.WriteLine("Processing JPEG...");
        }
    }
}
