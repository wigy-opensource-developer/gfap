using System.Linq;
using Xunit;

namespace Wigy.Gfap.Core.Test
{
    public class BranchTest
    {
        private readonly Branch _branch;
        private readonly Revision.Numbered _revision;
        private readonly Revision.Numbered _laterRevision;

        public BranchTest()
        {
            _branch = new Branch(null);
            _revision = Revision.Number(3);
            _laterRevision = Revision.Number(4);
        }

        [Fact]
        void AddedRevisionIsReturned()
        {
            _branch.Add(_revision);

            Assert.Contains(_revision, _branch.Revisions);
        }

        [Fact]
        void RevisionCanBeAddedTwice()
        {
            var first = _branch.Add(_revision);
            var second = _branch.Add(_revision);

            Assert.Equal(1, _branch.Revisions.Count());
            Assert.True(first);
            Assert.False(second);
        }


        [Fact]
        void RevisionsAreSorted()
        {
            _branch.Add(_laterRevision);
            _branch.Add(_revision);

            var revisions = _branch.Revisions.ToArray();
            Assert.Equal(2, revisions.Length);
            Assert.Same(_revision, revisions[0]);
            Assert.Same(_laterRevision, revisions[1]);
        }
    }
}
