using System;

namespace Wigy.Gfap.Core
{
    public abstract class Revision
    {
        public static Numbered Number(int r)
            => new Numbered(r);

        public class Numbered : Revision, IComparable<Numbered>
        {
            public Numbered(int number)
            {
                if (number <= 0)
                    throw new ArgumentException(nameof(number));
                Number = number;
            }

            public new int Number { get; }

            public override string ToString() => $"r{Number}";

            int IComparable<Numbered>.CompareTo(Numbered other)
                => Number.CompareTo(other.Number);
        }
    }
}
