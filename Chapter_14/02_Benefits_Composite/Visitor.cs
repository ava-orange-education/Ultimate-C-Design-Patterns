using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14._02_Benefits_Composite
{
    class Visitor
    {
        public void Explore()
        {
            MuseumItem gallery = new ExhibitRoom("Main Gallery");
            MuseumItem painting = new Exhibit("Starry Night");
            MuseumItem sculpture = new Exhibit("The Thinker");
            ExhibitRoom annex = new ExhibitRoom("Annex Room");

            annex.Add(sculpture);
            gallery.Add(painting);
            gallery.Add(annex);

            gallery.Display();
        }
    }
}
