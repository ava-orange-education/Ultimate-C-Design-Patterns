using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._10_Examples_Lazy.Gallery_App
{
    class GalleryApp
    {
        public void Run()
        {
            IPhoto photo1 = new PhotoProxy("beach.jpg");
            IPhoto photo2 = new PhotoProxy("mountains.jpg");

            Console.WriteLine("Gallery loaded. No photos initialized yet.");

            photo1.Display(); // Loads and displays beach.jpg
            photo2.Display(); // Loads and displays mountains.jpg
        }
    }
}
