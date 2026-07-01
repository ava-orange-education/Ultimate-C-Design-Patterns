using System;

namespace Chapter_18._02_01_Cloud_Native
{
    public interface IMemoryCache
    {
        void Set(string cacheKey, UserDto user, TimeSpan timeSpan);
        bool TryGetValue(string cacheKey, out UserDto cached);
    }
}