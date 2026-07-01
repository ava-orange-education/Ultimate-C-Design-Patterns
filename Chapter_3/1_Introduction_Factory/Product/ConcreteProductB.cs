using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._1_Introduction.Product
{
    class ConcreteProductB : Product
    {
        public override void ShowInfo() => Console.WriteLine("Product B created.");
    }
}
