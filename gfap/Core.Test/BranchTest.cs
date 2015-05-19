using System;
using Xunit;

namespace Wigy.Gfap.Core.Test
{
    class BranchTest
    {
        private readonly BuildProject _project;
        private readonly Revision _revision;

        public BranchTest()
        {
            _project = new BuildProject();
            _revision = new Revision();
        }

        [Fact]
        void BuildConstructor()
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
