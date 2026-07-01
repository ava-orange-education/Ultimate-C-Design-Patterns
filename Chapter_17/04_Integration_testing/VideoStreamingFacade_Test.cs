using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_17._04_Integration_testing
{
    internal class VideoStreamingFacade_Test
    {
        [Fact]
        public void Facade_ShouldCoordinateStreamingProcess()
        {
            var encoder = new Encoder();
            var storage = new Storage();
            var notifier = new Notifier();
            var facade = new VideoStreamingFacade(encoder, storage, notifier);

            var result = facade.StreamVideo("raw-footage");

            Assert.True(result);
        }
    }
}
