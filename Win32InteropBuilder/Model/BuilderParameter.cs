using System;
using System.CodeDom.Compiler;

namespace Win32InteropBuilder.Model
{
    public class BuilderParameter : IComparable, IComparable<BuilderParameter>, IDocumentable
    {
        public BuilderParameter(string name, int sequenceNumber)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
            SequenceNumber = sequenceNumber;
        }

        public string Name { get; }
        public int SequenceNumber { get; }
        public virtual BuilderType? Type { get; set; }
        public virtual string? Documentation { get; set; }

        public virtual void GeneratedCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
            if (Type == null)
                throw new InvalidOperationException();

            writer.Write(Type.FinalGeneratedName);
            writer.Write(' ');
            writer.Write(Name);
        }

        int IComparable.CompareTo(object? obj) => CompareTo(obj as BuilderParameter);
        public int CompareTo(BuilderParameter? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return SequenceNumber.CompareTo(other.SequenceNumber);
        }

        public override string ToString() => $"{Type} {Name}";
    }
}
