using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10._09_Examples_Memento.Rolling_Back
{
    public class WorkflowState
    {
        public string Email { get; set; }
        public bool DatabaseUpdated { get; set; }
        public bool WelcomeEmailSent { get; set; }
    }
}
