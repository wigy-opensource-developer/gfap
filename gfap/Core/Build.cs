using System;

namespace Wigy.Gfap.Core
{
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