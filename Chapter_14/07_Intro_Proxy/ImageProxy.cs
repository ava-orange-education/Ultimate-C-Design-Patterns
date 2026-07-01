using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._07_Intro_Proxy
{
    class ImageProxy : IDisplayable
    {
        private string filename;
        private RealImage realImage;

        public ImageProxy(string filename)
        {
            this.filename = filename;
        }

        public override void Show()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Show();
        }
    }
}
