using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class AdminValidator : IUserValidator
    {
        public bool Validate(User user) => user.Email.EndsWith("@company.com");
    }
}
