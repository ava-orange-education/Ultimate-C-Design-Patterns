using Chapter_1._6_Introduction_Abstract_Factory.Product_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.UIFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
