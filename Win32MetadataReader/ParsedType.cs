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

        private string? ArrayText
        {
            get
            {
                if (!ArrayShape.HasValue)
                    return null;

                string? s = null;
                for (var i = 0; i < ArrayShape.Value.Rank; i++)
                {
                    if (ArrayShape.Value.LowerBounds[i] != 0)
                        throw new InvalidOperationException();

                    s += "[" + ArrayShape.Value.Sizes + "]";
                }
                return s;
            }
        }

        public string GetCppName(ParsedParameter? parameter)
        {
            if (FullNameString == typeof(void).FullName)
                return "void";

            if (FullNameString == typeof(Guid).FullName)
                return "GUID";

            if (FullNameString == typeof(int).FullName)
                return "int";

            if (FullNameString == typeof(uint).FullName)
            {
                if (parameter?.Name.StartsWith("dw") == true)
                    return "DWORD";

                return "unsigned int";
            }

            if (FullNameString == typeof(short).FullName)
                return "short";

            if (FullNameString == typeof(ushort).FullName)
                return "unsigned short";

            if (FullNameString == typeof(long).FullName)
                return "LONGLONG";

            if (FullNameString == typeof(ulong).FullName)
                return "ULONGLONG";

            if (FullNameString == typeof(bool).FullName)
                return "BOOL";

            if (FullNameString == typeof(byte).FullName)
                return "unsigned char";

            if (FullNameString == typeof(sbyte).FullName)
                return "char";

            if (FullNameString == typeof(float).FullName)
                return "float";

            if (FullNameString == typeof(double).FullName)
                return "double";

            if (FullNameString == typeof(nuint).FullName)
                return "UINT_PTR";

            if (FullNameString == typeof(nint).FullName)
                return "INT_PTR";

            return Name;
        }

        public string GetCppWithIndirectionsName(ParsedParameter parameter)
        {
            ArgumentNullException.ThrowIfNull(parameter);

            var cppName = GetCppName(parameter);
            if (cppName == "ITEMIDLIST" && Indirections > 0)
            {
                if (parameter.IsConst || parameter.IsIn)
                    return "LPC" + cppName + new string('*', Indirections - 1) + ArrayText;

                return "LP" + cppName + new string('*', Indirections - 1) + ArrayText;
            }

            return cppName + new string('*', Indirections) + ArrayText;
        }

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
