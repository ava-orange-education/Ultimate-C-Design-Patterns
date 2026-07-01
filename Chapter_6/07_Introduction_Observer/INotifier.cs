using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6._07_Introduction_Observer
{
    public interface INotifier
    {
        void Register(IListener listener);
        void Unregister(IListener listener);
        void AlertListeners();
    }
}
