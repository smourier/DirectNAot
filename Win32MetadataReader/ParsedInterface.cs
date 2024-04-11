using System.Collections.Generic;

namespace Win32MetadataReader
{
    public class ParsedInterface(FullName fullName, FullName baseFullName) : ParsedType(fullName)
    {
        private readonly List<ParsedMethod> _methods = [];

        public FullName BaseFullName { get; } = baseFullName;
        public ParsedInterface? BaseInterface { get; set; }
        public IList<ParsedMethod> Methods => _methods;

        public IEnumerable<ParsedInterface> AllInterfaces
        {
            get
            {
                if (IsUnknown || IsDispatch)
                    yield break;

                if (BaseInterface != null)
                {
                    foreach (var bi in BaseInterface.AllInterfaces)
                    {
                        yield return bi;
                    }
                }
                yield return this;
            }
        }
    }
}
