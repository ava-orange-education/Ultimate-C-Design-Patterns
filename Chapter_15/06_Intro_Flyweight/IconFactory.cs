using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._06_Intro_Flyweight
{
    class IconFactory
    {
        private Hashtable icons = new Hashtable();

        public IconFactory()
        {
            icons.Add("Save", new SharedIcon());
            icons.Add("Open", new SharedIcon());
            icons.Add("Print", new SharedIcon());
        }

        public Icon GetIcon(string key)
        {
            if (!icons.ContainsKey(key))
                icons.Add(key, new SharedIcon());
            return icons[key] as Icon;
        }
    }
}
