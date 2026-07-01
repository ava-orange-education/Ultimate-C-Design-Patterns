using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chapter_16._08_Implementation_Dependency
{
    public class HomeController : Controller
    {
        private readonly IMessageSender _sender;

        public HomeController(IMessageSender sender)
        {
            _sender = sender;
        }

        public IActionResult Index()
        {
            _sender.Send("Welcome to the homepage!");
            return (IActionResult)View();
        }
    }
}
