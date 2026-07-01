using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_18._02_01_Cloud_Native
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IUserRepository _repository;
        private readonly IEmailService _emailService;

        public RegisterUserHandler(IUserRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var userId = await _repository.CreateAsync(request.Email, request.Password);
            await _emailService.SendWelcomeEmail(request.Email);
            return userId;
        }
    }
}
