using System;
using System.Collections.Generic;

namespace Wigy.Gfap.Core
{
    public class Branch
    {
        private readonly ISet<Revision.Numbered> _revisions;

        public Branch(Branch basedOn)
        {
            BasedOn = basedOn;
            _revisions = new SortedSet<Revision.Numbered>();
        }

        public Branch BasedOn { get; }

        public IEnumerable<Revision.Numbered> Revisions => _revisions;

        public void Add(Revision.Numbered revision)
        {
            _revisions.Add(revision);
        }
    }

}