using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Plugin
{
    public interface IPlugin
    {
        string Name { get; }
        void Execute();
    }
}
