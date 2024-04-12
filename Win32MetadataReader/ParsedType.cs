using System;
using System.Reflection.Metadata;

namespace Win32MetadataReader
{
    public class ParsedType(FullName fullName) : IEquatable<ParsedType>
    {
        public ParsedType(Type type)
            : this(new FullName(type))
        {
        }

        public FullName FullName { get; } = fullName;
        public int Indirections { get; set; }
        public ArrayShape? ArrayShape { get; set; }
        public string Name => FullName.Name;
        public string Namespace => FullName.Namespace;
        public string FullNameString => Namespace + "." + Name;
        public string WithIndirectionsName => Name + new string('*', Indirections);
        public ParsedType PointerType => new ParsedType(FullName) { Indirections = Indirections + 1 };
        public bool IsUnknown => FullName == FullName.IUnknown;
        public bool IsDispatch => FullName == FullName.IDispatch;
        public bool IsHRESULT => FullName == FullName.HRESULT;

        public ParsedType Clone() => new(FullName)
        {
            ArrayShape = ArrayShape,
            Indirections = Indirections
        };

        public override int GetHashCode() => FullName.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as ParsedType);
        public bool Equals(ParsedType? other) => other != null && other.FullName == FullName && other.Indirections == Indirections;
        public override string ToString() => WithIndirectionsName;
    }
}
