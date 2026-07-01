using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._02_Benefits_Strategy
{
    public class ArchiveTool
    {
        private ICompressionStrategy _strategy;

        public ArchiveTool(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ICompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteCompression()
        {
            _strategy.Compress();
        }
    }
}
