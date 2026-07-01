using Chapter_1._6_Introduction_Abstract_Factory.UI_Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._10_Best_Practices__Abstract_Factory
{
    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkButton();
        public ICheckbox CreateCheckbox() => new DarkCheckbox();
    }
}
