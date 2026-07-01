using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._09_Implementation_Proxy.Video_loader
{
    class VideoProxy : IPlayable
    {
        private string filename;
        private RealVideo realVideo;

        public VideoProxy(string filename)
        {
            this.filename = filename;
        }

        public void Play()
        {
            if (realVideo == null)
            {
                Console.WriteLine("Initializing video...");
                realVideo = new RealVideo(filename);
            }
            realVideo.Play();
        }
    }
}
