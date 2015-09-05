using System;
using Xunit;

namespace Wigy.Gfap.Core.Test
{
    public class RevisionConstructorTest
    {
        [Fact]
        void NumberedRevisionToString()
        {
            var revision = Revision.Number(46564);

            Assert.Equal("r46564", revision.ToString());
        }

        [Fact]
        void NumberIsNotZero()
        {
            Assert.Throws<ArgumentException>(() => Revision.Number(0));
        }

        [Fact]
        void NumberIsNotNegative()
        {
            Assert.Throws<ArgumentException>(() => Revision.Number(-5));
        }
    }
}