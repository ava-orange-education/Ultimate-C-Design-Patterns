using Chapter_1._6_Introduction_Abstract_Factory.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.Benefits_Abstract_Factory.DarkThemeFactory
{
    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkModeButton();
        public ICheckbox CreateCheckbox() => new DarkModeCheckbox();
    }
}
