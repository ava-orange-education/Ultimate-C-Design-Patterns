using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._01_Introduction
{
    internal class EmailSubscriber_Test
    {
        [Fact]
        public void Subscriber_ShouldReceiveNotification()
        {
            var subscriber = new EmailSubscriber();
            var publisher = new Publisher();
            publisher.Subscribe(subscriber);

            publisher.Notify("Hello, world!");

            Assert.Equal("Hello, world!", subscriber.LastMessage);
        }

    }
}
