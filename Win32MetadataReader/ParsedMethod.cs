using System;
using System.Collections.Generic;

namespace Win32MetadataReader
{
    public class ParsedMethod
    {
        private readonly List<ParsedParameter> _parameters = [];

        public ParsedMethod(ParsedInterface parent, string name)
        {
            ArgumentNullException.ThrowIfNull(parent);

            Parent = parent;
            Name = name;
        }

        public ParsedInterface Parent { get; }
        public string Name { get; }
        public ParsedType? ReturnType { get; set; }
        public IList<ParsedParameter> Parameters => _parameters;

        public override string ToString() => Name;
    }
}
