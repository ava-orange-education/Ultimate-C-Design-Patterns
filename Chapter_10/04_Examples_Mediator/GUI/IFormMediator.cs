using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.GUI
{
    public interface IFormMediator
    {
        void FieldChanged(string field);
    }
}
