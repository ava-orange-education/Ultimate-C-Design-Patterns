using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._07_Intro_Proxy
{
    class Viewer
    {
        public void Run()
        {
            IDisplayable image = new ImageProxy("sunset.jpg");
            image.Show(); // Loads and displays the image only when called
        }
    }
}
