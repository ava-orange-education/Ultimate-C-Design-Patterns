using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._07_Implementation_Facade
{
    public class AudioExtractor
    {
        public void ExtractAudio(string filePath)
        {
            Console.WriteLine($"Extracting audio from: {filePath}");
        }
    }
}
