using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.Product_Interfaces
{
    internal class Linux_versions
    {
    }

    public class LinuxButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering a Linux button!");
    }

    public class LinuxCheckbox : ICheckbox
    {
        public void Check() => Console.WriteLine("Checking a Linux checkbox!");
    }

}
