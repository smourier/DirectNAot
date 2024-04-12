using System;

namespace Win32InteropBuilder.Model
{
    public class BuilderParameter : IComparable, IComparable<BuilderParameter>
    {
        public BuilderParameter(string name, int sequenceNumber)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            SequenceNumber = sequenceNumber;
        }

        public string Name { get; }
        public BuilderType? Type { get; set; }
        public int SequenceNumber { get; }

        int IComparable.CompareTo(object? obj) => CompareTo(obj as BuilderParameter);
        public int CompareTo(BuilderParameter? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return SequenceNumber.CompareTo(other.SequenceNumber);
        }

        public override string ToString() => $"{Type} {Name}";
    }
}
