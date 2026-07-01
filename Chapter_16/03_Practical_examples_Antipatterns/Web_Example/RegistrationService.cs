using Chapter_16._02_Common_Antipatterns;
using System;

namespace Chapter_16._03_Practical_examples_Antipatterns.Web_Example
{
    public class RegistrationService
    {
        private readonly IUserRepository _userRepo;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public RegistrationService(IUserRepository userRepo, IEmailSender emailSender, ILogger logger)
        {
            _userRepo = userRepo;
            _emailSender = emailSender;
            _logger = logger;
        }

        public RegistrationResult Register(UserDto dto)
        {
            if (!IsValidEmail(dto.Email))
                return RegistrationResult.Failure("Invalid email");

            var user = new User { Email = dto.Email, Password = Hash(dto.Password) };
            _userRepo.Save(user);
            _emailSender.SendWelcomeEmail(user.Email);
            _logger.LogInfo($"New user registered: {user.Email}");

            return RegistrationResult.Success();
        }

        private object Hash(object password)
        {
            throw new NotImplementedException();
        }

        private bool IsValidEmail(string email)
        {
            throw new NotImplementedException();
        }
    }

}