using Chapter_16._02_Common_Antipatterns;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chapter_16._03_Practical_examples_Antipatterns.Web_Example
{
    internal class RegisterController
    {
        private Context _dbContext;
        private RegistrationService _registrationService;

        public Logger Logger { get; private set; }
        public EmailService EmailService { get; private set; }

        [HttpPost]
        public IActionResult Register(UserDto dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || !dto.Email.Contains("@"))
                return BadRequest("Invalid email");

            var user = new User { Email = dto.Email, Password = HashSet(dto.Password) };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            EmailService.SendWelcomeEmail(user.Email);
            Logger.Log($"New user registered: {user.Email}");

            return Ok();
        }

        [HttpPost]
        public IActionResult Register1(UserDto dto)
        {
            var result = _registrationService.Register(dto);
            //if (!result.Success)
            //    return BadRequest(result.ErrorMessage);

            return Ok();
        }

        private IActionResult BadRequest(object errorMessage)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }

        private object HashSet(object password)
        {
            throw new NotImplementedException();
        }

        private IActionResult BadRequest(string v)
        {
            throw new NotImplementedException();
        }
    }
}
