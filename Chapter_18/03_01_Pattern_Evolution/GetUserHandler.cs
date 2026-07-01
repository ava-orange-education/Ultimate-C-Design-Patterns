using Chapter_18._02_01_Cloud_Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_18._03_01_Pattern_Evolution
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IUserRepository _repository;

        public GetUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetUserAsync(request.UserId);
        }
    }
}
