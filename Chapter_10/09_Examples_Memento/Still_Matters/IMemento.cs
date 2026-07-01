using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Still_Matters
{
    public interface IMemento<T>
    {
        T State { get; }
    }
}
