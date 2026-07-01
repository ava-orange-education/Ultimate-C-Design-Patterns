using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15._04_Examples_Bridge
{
    class ConfirmationDialog : DialogBox
    {
        public ConfirmationDialog(IRenderer renderer) : base(renderer) { }

        public override void Show(string title, string message)
        {
            Console.WriteLine("Preparing confirmation dialog...");
            renderer.DrawDialog(title, message);
        }
    }
}
