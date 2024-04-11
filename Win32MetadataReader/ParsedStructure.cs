using System.Collections.Generic;

namespace Win32MetadataReader
{
    public class ParsedStructure(FullName fullName) : ParsedType(fullName)
    {
        private readonly List<ParsedField> _fields = new();

        public IList<ParsedField> Fields => _fields;
    }
}
