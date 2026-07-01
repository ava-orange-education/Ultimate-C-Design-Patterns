using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chapter_16._09_Examples_ASP_NET_Core
{
    public class AccountController : Controller
    {
        private readonly IWelcomeEmailSender _emailSender;

        public AccountController(IWelcomeEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult Register(string email)
        {
            _emailSender.Send(email);
            return Ok();
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }
    }
}
