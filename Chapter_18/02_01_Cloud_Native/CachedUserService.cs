using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._02_01_Cloud_Native
{
    public class CachedUserService : IUserService
    {
        private readonly IUserService _inner;
        private readonly IMemoryCache _cache;

        public CachedUserService(IUserService inner, IMemoryCache cache)
        {
            _inner = inner;
            _cache = cache;
        }

        public async Task<UserDto> GetUserAsync(Guid userId)
        {
            var cacheKey = $"user:{userId}";
            if (_cache.TryGetValue(cacheKey, out UserDto cached))
                return cached;

            var user = await _inner.GetUserAsync(userId);
            _cache.Set(cacheKey, user, TimeSpan.FromMinutes(10));
            return user;
        }
    }
}
