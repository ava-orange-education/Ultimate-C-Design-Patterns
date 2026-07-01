using System;
using System.Threading.Tasks;

namespace Chapter_18._02_01_Cloud_Native
{
    public interface IUserRepository
    {
        Task<Guid> CreateAsync(string email, string password);
        Task<UserDto> GetUserAsync(Guid userId);
    }
}