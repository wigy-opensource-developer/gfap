using System;
using Xunit;

namespace Wigy.Gfap.Core.Test
{
    public class RevisionConstructorTest
    {
        public RevisionConstructorTest()
        {
        }

        [Fact]
        void NumberedRevisionToString()
        {
            var revision = Revision.Number(46564);

            Assert.Equal(revision.ToString(), "r46564");
        }
    }

    public class BuildConstructorTest
    {
        private readonly BuildProject _project;
        private readonly Revision _revision;

        public BuildConstructorTest()
        {
            _project = new BuildProject();
            _revision = Revision.Number(5);
        }

        [Fact]
        void SetsProjectAndRevision()
        {
            var build = new Build(_project, _revision);

            Assert.Same(_project, build.Project);
            Assert.Same(_revision, build.Revision);
        }

        [Fact]
        void BuildHasProject()
        {
            Assert.Throws<ArgumentNullException>(() => new Build(null, _revision));
        }

        [Fact]
        void BuildHasRevision()
        {
            Assert.Throws<ArgumentNullException>(() => new Build(_project, null));
        }
    }
}
