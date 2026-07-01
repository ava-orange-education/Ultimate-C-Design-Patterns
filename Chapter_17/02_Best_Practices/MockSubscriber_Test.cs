using Chapter_17._01_Introduction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._02_Best_Practices
{
    internal class MockSubscriber_Test
    {
        [Fact]
        public void Notify_ShouldCallUpdateOnSubscriber()
        {
            var subscriber = new MockSubscriber();
            var publisher = new Publisher();
            publisher.Subscribe(subscriber);

            publisher.Notify("New article available");

            Assert.True(subscriber.WasNotified);
        }
    }
}
