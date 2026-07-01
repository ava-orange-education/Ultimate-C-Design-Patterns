using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_03_Emerging_Paradigm
{
    public class UserProfile
    {
        private string _email;
        private string _phone;

        public string GetMaskedEmail()
        {
            var parts = _email.Split('@');
            return $"{parts[0].Substring(0, 2)}***@{parts[1]}";
        }

        public void SetEmail(string email)
        {
            if (!email.Contains("@"))
                throw new ArgumentException("Invalid email");
            _email = email;
        }

        public void SetPhone(string phone)
        {
            if (phone.Length != 10)
                throw new ArgumentException("Invalid phone");
            _phone = phone;
        }
    }
}
