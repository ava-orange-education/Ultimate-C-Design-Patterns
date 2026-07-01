using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_14._10_Examples_Lazy.Gallery_App
{
    class HighResPhoto : IPhoto
    {
        private string filename;

        public HighResPhoto(string filename)
        {
            this.filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading high-res photo: {filename}");
            Thread.Sleep(1000); // Simulate delay
        }

        public void Display()
        {
            Console.WriteLine($"Displaying photo: {filename}");
        }
    }
}
