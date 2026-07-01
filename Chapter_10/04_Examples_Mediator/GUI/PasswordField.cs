using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._04_Examples_Mediator.GUI
{
    public class PasswordField
    {
        private readonly IFormMediator mediator;
        public string Content { get; private set; }

        public PasswordField(IFormMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Input(string value)
        {
            Content = value;
            mediator.FieldChanged("Password");
        }
    }
}
