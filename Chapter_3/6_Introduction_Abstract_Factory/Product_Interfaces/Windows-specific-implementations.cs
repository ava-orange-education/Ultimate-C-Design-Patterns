using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.Product_Interfaces
{
    internal class Windows_specific_implementations
    {
    }

    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering a Windows button!");
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking a Windows checkbox!");
    }
    ///Similarly, we define MacOS versions:

    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering a Mac button!");
    }

    public class MacCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking a Mac checkbox!");
    }

}
