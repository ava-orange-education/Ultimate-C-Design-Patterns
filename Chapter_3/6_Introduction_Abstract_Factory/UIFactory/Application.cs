using Chapter_1._6_Introduction_Abstract_Factory.Product_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.UIFactory
{
    class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _checkbox.Check();
        }
    }
}
