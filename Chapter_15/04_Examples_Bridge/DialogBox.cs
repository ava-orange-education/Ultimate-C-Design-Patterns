using Chapter_15._03_Implementation_Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._04_Examples_Bridge
{
    abstract class DialogBox
    {
        protected IRenderer renderer;

        public DialogBox(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public IRenderer Renderer
        {
            set { renderer = value; }
        }

        public abstract void Show(string title, string message);
    }
}
