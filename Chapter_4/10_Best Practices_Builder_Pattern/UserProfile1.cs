using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._10_Best_Practices_Builder_Pattern
{
    public class UserProfile1
    {
        public string Username { get; }
        public string Email { get; }
        public int Age { get; }
        public string ThemePreference { get; }
        public bool ReceiveNewsletters { get; }

        private UserProfile1(Builder builder)
        {
            Username = builder.Username;
            Email = builder.Email;
            Age = builder.Age;
            ThemePreference = builder.ThemePreference;
            ReceiveNewsletters = builder.ReceiveNewsletters;
        }

        public class Builder
        {
            public string Username;
            public string Email;
            public int Age;
            public string ThemePreference = "Light";
            public bool ReceiveNewsletters = true;

            public Builder WithUsername(string username) { Username = username; return this; }
            public Builder WithEmail(string email) { Email = email; return this; }
            public Builder WithAge(int age) { Age = age; return this; }
            public Builder WithTheme(string theme) { ThemePreference = theme; return this; }
            public Builder WithNewsletterSubscription(bool subscribe) { ReceiveNewsletters = subscribe; return this; }

            public UserProfile1 Build() => new UserProfile1(this);
        }
    }

}
