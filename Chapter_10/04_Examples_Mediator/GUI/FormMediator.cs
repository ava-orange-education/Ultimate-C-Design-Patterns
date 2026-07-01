using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.GUI
{
    public class FormMediator : IFormMediator
    {
        public UsernameField Username { get; set; }
        public PasswordField Password { get; set; }
        public SubmitButton Button { get; set; }

        public void FieldChanged(string field)
        {
            if (!string.IsNullOrEmpty(Username.Content) && !string.IsNullOrEmpty(Password.Content))
                Button.SetEnabled(true);
            else
                Button.SetEnabled(false);
        }
    }
}
