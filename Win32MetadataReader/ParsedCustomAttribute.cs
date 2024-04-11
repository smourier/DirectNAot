namespace Win32MetadataReader
{
    public class ParsedCustomAttribute(FullName fullName) : ParsedType(fullName)
    {
        public string ShortName
        {
            get
            {
                const string token = "Attribute";
                if (Name == null)
                    return string.Empty;

                if (Name.Length > token.Length && Name.EndsWith(token))
                    return Name[..^token.Length];

                return Name;
            }
        }

        public override string ToString() => ShortName;
    }
}
