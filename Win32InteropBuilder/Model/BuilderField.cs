using System;
using System.Reflection;

namespace Win32InteropBuilder.Model
{
    public class BuilderField : IDocumentable, IComparable, IComparable<BuilderField>
    {
        public BuilderField(string name, BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(name);
            ArgumentNullException.ThrowIfNull(type);
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public BuilderType Type { get; }
        public virtual FieldAttributes Attributes { get; set; }
        public virtual int? Offset { get; set; }
        public virtual byte[]? DefaultValueAsBytes { get; set; }
        public virtual string? Documentation { get; set; }
        public object? DefaultValue => Type.GetValue(DefaultValueAsBytes);

        int IComparable.CompareTo(object? obj) => CompareTo(obj as BuilderField);
        public int CompareTo(BuilderField? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return Name.CompareTo(other.Name);
        }

        public override string ToString() => Name;
    }
}
