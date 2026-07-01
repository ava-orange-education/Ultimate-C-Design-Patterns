using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13._05_Introduction_Facade
{
    public class AudioProcessor
    {
        public void NormalizeAudio(string file)
        {
            Console.WriteLine($"Normalizing audio in {file}");
        }
    }
}
