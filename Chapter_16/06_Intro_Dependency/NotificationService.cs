using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16._06_Intro_Dependency
{
    public class NotificationService
    {
        private readonly EmailSender _emailSender = new EmailSender();

        public void Notify(string message)
        {
            _emailSender.Send(message);
        }
    }
}
