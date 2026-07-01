using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Still_Matters
{
    public class GenericMemento<T> : IMemento<T>
    {
        public T State { get; }

        public GenericMemento(T state)
        {
            State = state;
        }
    }
}
