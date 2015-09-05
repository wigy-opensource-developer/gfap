using System;
using Xunit;

namespace Wigy.Gfap.Core.Test
{
    public class BuildProjectConstructorTest
    {
        [Fact]
        void SetsProjectName()
        {
            const string NAME = "Trunk unit tests";
            var buildProject = new BuildProject(NAME);

            Assert.Equal(NAME, buildProject.Name);
        }

        [Fact]
        void NameIsNotNull()
        {
            Assert.Throws<ArgumentException>(() => new BuildProject(null));
        }

        [Fact]
        void NameIsNotJustWhitespace()
        {
            Assert.Throws<ArgumentException>(() => new BuildProject(" \t\r\n"));
        }
    }
}