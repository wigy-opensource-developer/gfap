using System;
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

    public abstract class Revision
    {
        public static Revision Number(int r) => new NumberRevision(r);

        private class NumberRevision : Revision
        {
            private readonly int _number;

            public NumberRevision(int number)
            {
                _number = number;
            }

            public override string ToString() => $"r{_number}";
        }
    }

    public class BuildProject
    {
    }

    public class Build
    {
        public Build(BuildProject project, Revision revision)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project));
            if (revision == null)
                throw new ArgumentNullException(nameof(revision));
            Project = project;
            Revision = revision;
        }

        public BuildProject Project { get; }
        public Revision Revision { get; }
    }
}