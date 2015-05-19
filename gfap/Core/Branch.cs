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

    public class Revision
    {
    }

    public class BuildProject
    {
    }

    public class Build
    {
        public Build(BuildProject project, Revision revision)
        {
            Project = project;
            Revision = revision;
        }

        public BuildProject Project { get; }
        public Revision Revision { get; }
    }
}