using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._05_Best_practices_Bridge
{
    abstract class AudioFile
    {
        protected IOutputDevice outputDevice;

        public AudioFile(IOutputDevice outputDevice)
        {
            this.outputDevice = outputDevice;
        }

        public IOutputDevice OutputDevice
        {
            set { outputDevice = value; }
        }

        public abstract void Play();
    }
}
