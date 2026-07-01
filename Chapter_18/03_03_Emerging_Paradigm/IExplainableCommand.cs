using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public interface IExplainableCommand
    {
        string Execute();
        string Explain();
    }
}
