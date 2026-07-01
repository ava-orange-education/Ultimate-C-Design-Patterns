using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    class Mp3File : AudioFile
    {
        private string fileName;

        public Mp3File(string fileName, IOutputDevice outputDevice) : base(outputDevice)
        {
            this.fileName = fileName;
        }

        public override void Play()
        {
            Console.WriteLine("Decoding MP3...");
            outputDevice.PlaySound(fileName);
        }
    }
}
