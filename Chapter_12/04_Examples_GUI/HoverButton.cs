using System.Drawing;
using System.Windows.Forms;

namespace Chapter_12._04_Examples_GUI
{
    public class HoverButton : Button
    {
        public HoverButton()
        {
            this.MouseEnter += (s, e) => this.BackColor = Color.LightBlue;
            this.MouseLeave += (s, e) => this.BackColor = SystemColors.Control;
        }
    }
}
