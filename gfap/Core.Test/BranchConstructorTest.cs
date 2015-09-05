using Xunit;

namespace Wigy.Gfap.Core.Test
{
    public class BranchConstructorTest
    {
        [Fact]
        void StartsWithNoRevisions()
        {
            var branch = new Branch(null);

            Assert.Empty(branch.Revisions);
        }

        [Fact]
        void SetsBasedOnProperty()
        {
            var baseBranch = new Branch(null);
            var branch = new Branch(baseBranch);

            Assert.Same(baseBranch, branch.BasedOn);
        }
    }
}
