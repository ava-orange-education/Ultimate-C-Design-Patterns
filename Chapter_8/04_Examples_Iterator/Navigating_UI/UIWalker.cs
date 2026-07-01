using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._04_Examples_Iterator.Navigating_UI
{
    class UIWalker
    {
        public IEnumerable<UIElement> Traverse(UIElement root)
        {
            yield return root;

            foreach (var child in root.Children)
            {
                foreach (var descendant in Traverse(child))
                {
                    yield return descendant;
                }
            }
        }
    }
}
