using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game.UI_state
{
    class HoveredState : IButtonState
    {
        public void Render(ButtonContext context)
        {
            Console.WriteLine("Button is glowing softly.");
        }

        public void OnMouseOver(ButtonContext context) { }

        public void OnClick(ButtonContext context)
        {
            Console.WriteLine("Button clicked!");
            context.State = new ClickedState();
        }
    }
}
