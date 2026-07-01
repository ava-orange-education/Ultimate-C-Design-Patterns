using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._01_01_Integrating_Patterns
{
    public class RegisterUserUseCase
    {
        private readonly IUserValidator _validator;

        public RegisterUserUseCase(IUserValidator validator)
        {
            _validator = validator;
        }

        public bool Execute(User user)
        {
            return _validator.Validate(user);
        }
    }
}
