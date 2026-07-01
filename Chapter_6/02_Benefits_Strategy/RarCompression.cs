using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._02_Benefits_Strategy
{
    public class RarCompression : ICompressionStrategy
    {
        public void Compress() => Console.WriteLine("Compressing using RAR format...");
    }
}
