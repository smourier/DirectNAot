using System;

namespace Win32MetadataReader
{
    public class ParsedField
    {
        public ParsedField(ParsedStructure parent, string name, ParsedType type)
        {
            ArgumentNullException.ThrowIfNull(parent);
            Parent = parent;
            Name = name;
            Type = type;
        }

        public ParsedStructure Parent { get; }
        public string Name { get; }
        public ParsedType Type { get; }

        public override string ToString() => (Type != null ? "???" : null) + " " + Name;
    }
}
