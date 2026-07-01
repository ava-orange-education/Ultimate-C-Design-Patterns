using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._04_Examples_Iterator.Navigating_UI
{
    abstract class UIElement
    {
        public string Name { get; set; }
        public List<UIElement> Children { get; } = new List<UIElement>();
    }
}
