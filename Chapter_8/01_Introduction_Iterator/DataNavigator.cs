using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._01_Introduction_Iterator
{
    abstract class DataNavigator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsFinished();
        public abstract object CurrentItem();
    }
}
