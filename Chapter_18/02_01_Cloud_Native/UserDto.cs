using System;

namespace Chapter_18._02_01_Cloud_Native
{
    public class UserDto
    {
        public static implicit operator UserDto(void v)
        {
            throw new NotImplementedException();
        }
    }
}