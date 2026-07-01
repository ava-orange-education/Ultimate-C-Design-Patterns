using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._03_Unit_Testing
{
    internal class NotificationFactory_Test
    {
        [Theory]
        [InlineData("email", "Email sent")]
        [InlineData("sms", "SMS sent")]
        public void Factory_ShouldCreateCorrectNotification(string type, string expected)
        {
            var notification = NotificationFactory.Create(type);
            Assert.Equal(expected, notification.Send());
        }
    }
}
