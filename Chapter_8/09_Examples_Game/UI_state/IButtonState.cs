using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._09_Examples_Game.UI_state
{
    interface IButtonState
    {
        void Render(ButtonContext context);
        void OnMouseOver(ButtonContext context);
        void OnClick(ButtonContext context);
    }
}
