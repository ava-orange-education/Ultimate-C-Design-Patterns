using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._06_Examples_Testing
{
    internal class Publisher_Test
    {
        [Fact]
        public void Notify_ShouldSendMessageToAllSubscribers()
        {
            var email = new EmailSubscriber();
            var publisher = new Publisher();
            publisher.Subscribe(email);

            publisher.Notify("New article available");

            Assert.Equal("New article available", email.LastMessage);
        }
    }
}
