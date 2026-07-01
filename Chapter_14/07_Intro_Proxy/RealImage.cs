using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._07_Intro_Proxy
{
    class RealImage : IDisplayable
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {filename}");
        }

        public override void Show()
        {
            Console.WriteLine($"Displaying image: {filename}");
        }
    }
}
