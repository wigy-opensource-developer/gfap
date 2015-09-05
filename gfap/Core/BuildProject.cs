using System;

namespace Wigy.Gfap.Core
{
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
}