using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._01_Introduction_Iterator
{
    abstract class DataCluster
    {
        public abstract DataNavigator CreateNavigator();
        public abstract int Length { get; protected set; }
        public abstract object this[int index] { get; set; }
    }
}
