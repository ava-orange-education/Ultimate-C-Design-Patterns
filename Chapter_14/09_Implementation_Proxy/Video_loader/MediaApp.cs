using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._09_Implementation_Proxy.Video_loader
{
    class MediaApp
    {
        public void Run()
        {
            IPlayable video = new VideoProxy("wildlife.mp4");
            Console.WriteLine("App loaded. Video not yet initialized.");
            video.Play(); // Loads and plays only when called
        }
    }
}
