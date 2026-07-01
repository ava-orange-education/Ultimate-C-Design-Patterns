using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_17._03_Unit_Testing
{
    public class SmsNotification : INotification
    {
        public string Send() => "SMS sent";
    }
}
