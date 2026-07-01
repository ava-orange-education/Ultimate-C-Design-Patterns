using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_02_Serverles
{
    public class ImageFunction
    {
        private readonly Dictionary<string, IImageProcessorStrategy> _strategies;

        public ImageFunction()
        {
            _strategies = new Dictionary<string, IImageProcessorStrategy>()
        {
            { "image/jpeg", new JpegProcessor() },
            { "image/png", new PngProcessor() }
        };
        }

        public async Task RunAsync(Stream imageStream, string contentType)
        {
            if (_strategies.TryGetValue(contentType, out var strategy))
            {
                await strategy.ProcessAsync(imageStream);
            }
            else
            {
                Console.WriteLine("Unsupported format.");
            }
        }
    }
}
