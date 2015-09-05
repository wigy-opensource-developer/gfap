using System.Collections.Generic;

namespace Wigy.Gfap.Core
{
    public class Branch
    {
        private readonly ISet<Revision> _revisions;

        public Branch(Branch basedOn)
        {
            BasedOn = basedOn;
            _revisions = new SortedSet<Revision>();
        }

        public Branch BasedOn { get; }

        public IEnumerable<Revision> Revisions => _revisions;
    }

}