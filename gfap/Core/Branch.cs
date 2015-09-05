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
            public NumberRevision(int number)
            {
                if (number <= 0)
                    throw new ArgumentException(nameof(number));
                Number = number;
            }

            public new int Number { get; }

            public override string ToString() => $"r{Number}";
        }
    }

    public class BuildProject
    {
        public BuildProject(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));
            Name = name;
        }

        public string Name { get; }
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