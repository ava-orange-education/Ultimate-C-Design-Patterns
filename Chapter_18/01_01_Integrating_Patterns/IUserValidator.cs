using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public interface IUserValidator
    {
        bool Validate(User user);
    }
}
