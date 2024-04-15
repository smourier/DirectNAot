using System;
using System.Reflection;

namespace Win32InteropBuilder.Model
{
    public class BuilderField : IDocumentable
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
        public virtual byte[]? DefaultValue { get; set; }
        public virtual string? Documentation { get; set; }

        public override string ToString() => Name;
    }
}
