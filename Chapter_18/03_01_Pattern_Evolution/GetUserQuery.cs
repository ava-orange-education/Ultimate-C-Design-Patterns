using Chapter_18._02_01_Cloud_Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_01_Pattern_Evolution
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public Guid UserId { get; }

        public GetUserQuery(Guid userId)
        {
            UserId = userId;
        }
    }
}
