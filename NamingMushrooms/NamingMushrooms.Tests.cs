using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NameTheNumber;

namespace NamingMushrooms
{
    public class NamingMushroomsTest
    {
        [Fact]
        public void ShouldReturnEnding()
        {
            var sut = new Mushroom();

            var t1 = sut.Message(17);
            var t2 = sut.Message(3);
            var t3 = sut.Message(36);
            var t4 = sut.Message(61);

            Assert.Equal("ов", t1);
            Assert.Equal("а", t2);
            Assert.Equal("ов", t3);
            Assert.Equal("", t4);
        }
    }
}
 