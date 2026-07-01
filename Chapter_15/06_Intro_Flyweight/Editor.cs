using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._06_Intro_Flyweight
{
    class Editor
    {
        static void Main()
        {
            int position = 100;

            IconFactory factory = new IconFactory();

            Icon saveIcon = factory.GetIcon("Save");
            saveIcon.Display(position++, position++);

            Icon openIcon = factory.GetIcon("Open");
            openIcon.Display(position++, position++);

            Icon printIcon = factory.GetIcon("Print");
            printIcon.Display(position++, position++);

            Icon unknownIcon = factory.GetIcon("Help");
            unknownIcon.Display(position++, position++);

            Icon userIcon = new CustomIcon("UserUploadedImage");
            userIcon.Display(position++, position++);
        }
    }
}
