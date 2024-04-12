using System;
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

        public override int GetHashCode() => FullName.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as BuilderType);
        public bool Equals(BuilderType? other) => other != null && other.FullName == FullName;
        public override string ToString() => FullName.ToString();
    }
}
