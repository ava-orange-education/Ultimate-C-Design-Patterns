using Chapter_1._6_Introduction_Abstract_Factory.Product_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.UIFactory
{
    internal class platform_specific_components
    {
    }

    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }

    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }

    public class LinuxUIFactory : IUIFactory
    {
        public IButton CreateButton() => new LinuxButton();
        public ICheckbox CreateCheckbox() => new LinuxCheckbox();
    }

}
