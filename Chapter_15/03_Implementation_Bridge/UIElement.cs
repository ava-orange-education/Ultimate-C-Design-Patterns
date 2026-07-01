using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._03_Implementation_Bridge
{
    abstract class UIElement
    {
        protected IRenderer renderer;
        protected string theme;

        public UIElement(IRenderer renderer, string theme)
        {
            this.renderer = renderer;
            this.theme = theme;
        }

        public IRenderer Renderer
        {
            set { renderer = value; }
        }

        public string Theme
        {
            set { theme = value; }
        }

        public abstract void Render();
    }
}
