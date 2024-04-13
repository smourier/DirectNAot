using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class BuilderType : IEquatable<BuilderType>
    {
        private readonly List<BuilderMethod> _methods = [];

        public BuilderType(FullName fullName)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            FullName = fullName;
        }

        public BuilderType(Type type)
            : this(new FullName(type))
        {
        }

        public FullName FullName { get; }
        public int Indirections { get; set; }
        public ArrayShape? ArrayShape { get; set; }
        public IList<BuilderMethod> Methods => _methods;

        public virtual string FileName => FullName.Name;

        public virtual void GeneratedCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
        }

        public override int GetHashCode() => FullName.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as BuilderType);
        public bool Equals(BuilderType? other) => other != null && other.FullName == FullName;
        public override string ToString() => FullName.ToString();

        public static BuilderType Int32 { get; } = new(typeof(int));
        public static BuilderType Int64 { get; } = new(typeof(long));
        public static BuilderType UInt32 { get; } = new(typeof(uint));
        public static BuilderType UInt64 { get; } = new(typeof(ulong));
        public static BuilderType Guid { get; } = new(typeof(Guid));
        public static BuilderType Void { get; } = new(typeof(void));
    }
}
