using Chapter_17._01_Introduction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._03_Unit_Testing
{
    internal class MockSubscriber_Test
    {
        [Fact]
        public void Observer_ShouldNotifySubscriber()
        {
            var subscriber = new MockSubscriber();
            var publisher = new Publisher();
            publisher.Subscribe(subscriber);
            publisher.Notify("Update available");

            Assert.True(subscriber.WasUpdated);
        }
    }
}
