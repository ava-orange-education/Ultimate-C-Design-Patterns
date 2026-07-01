using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._01_Intro_Bridge
{
    abstract class Shape
    {
        protected Renderer renderer;

        public Renderer Renderer
        {
            set { renderer = value; }
        }

        public Shape(Renderer renderer)
        {
            this.renderer = renderer;
        }

        public virtual void Draw()
        {
            renderer.RenderShape();
        }
    }
}
