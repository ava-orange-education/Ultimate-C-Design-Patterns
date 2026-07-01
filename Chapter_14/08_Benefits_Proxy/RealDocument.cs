using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter_14._08_Benefits_Proxy
{
    class RealDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Document opened successfully.");
        }
    }
}
