using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.GUI
{
    public class SubmitButton
    {
        public void SetEnabled(bool enabled)
        {
            Console.WriteLine(enabled
                ? "Submit Button Enabled."
                : "Submit Button Disabled.");
        }
    }
}
