using System;

namespace Wigy.Gfap.Core
{
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
}
