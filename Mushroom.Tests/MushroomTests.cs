using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NameTheNumber;

namespace Naming.Tests
{
    [TestFixture]
    public class MushroomTests
    {
        [Test]
        public void ShouldReturnEnding()
        {
            Mushroom sut = new Mushroom();

            var result = sut.Message(17);

            Assert.That(result, Is.EqualTo("ов"));
        }

    }
}
