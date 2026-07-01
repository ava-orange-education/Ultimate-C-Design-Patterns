using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._10_Examples_Lazy.Gallery_App
{
    class PhotoProxy : IPhoto
    {
        private string filename;
        private HighResPhoto realPhoto;

        public PhotoProxy(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realPhoto == null)
            {
                Console.WriteLine("Initializing photo...");
                realPhoto = new HighResPhoto(filename);
            }
            realPhoto.Display();
        }
    }
}
