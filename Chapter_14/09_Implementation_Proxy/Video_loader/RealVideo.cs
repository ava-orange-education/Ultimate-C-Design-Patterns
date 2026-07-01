using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_14._09_Implementation_Proxy.Video_loader
{
    class RealVideo : IPlayable
    {
        private string filename;

        public RealVideo(string filename)
        {
            this.filename = filename;
            LoadVideo();
        }

        private void LoadVideo()
        {
            Console.WriteLine($"Loading video file: {filename}");
            // Simulate expensive operation
            Thread.Sleep(1000);
        }

        public void Play()
        {
            Console.WriteLine($"Playing video: {filename}");
        }
    }
}
