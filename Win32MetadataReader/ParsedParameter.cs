﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Win32MetadataReader
{
    public class ParsedParameter(ParsedMethod? parent, string name, ParameterAttributes attributes, int sequenceNumber)
    {
        private readonly List<ParsedCustomAttribute> _customAttributes = new();

        public ParsedMethod? Parent { get; } = parent; // can be null
        public string Name { get; } = name;
        public ParsedType Type { get; set; } = new ParsedType(FullName.Invalid); // will be setup after
        public ParameterAttributes Attributes { get; } = attributes;
        public int SequenceNumber { get; } = sequenceNumber;
        public IList<ParsedCustomAttribute> CustomAttributes => _customAttributes;
        public bool IsConst => CustomAttributes.Any(a => a.FullName == FullName.ConstAttribute);
        public bool IsOut => Attributes.HasFlag(ParameterAttributes.Out);
        public bool IsIn => Attributes.HasFlag(ParameterAttributes.In);
        public bool IsOptional => Attributes.HasFlag(ParameterAttributes.Optional);

        public string GenerateCppMethodSignature()
        {
            if (IsConst && Type?.GetCppWithIndirectionsName(this) == "GUID*")
                return "const IID &";

            var cas = IsConst ? "const" : string.Empty;
            var typeName = Type?.GetCppWithIndirectionsName(this) ?? "???";
            var list = new List<string>
            {
                cas,
                typeName,
                Name
            };
            return string.Join(" ", list.Where(i => !string.IsNullOrWhiteSpace(i)));
        }

        public override string ToString()
        {
            var cas = string.Join(string.Empty, CustomAttributes.Select(a => "[" + a.ShortName + "]"));
            var typeName = Type?.GetCppWithIndirectionsName(this) ?? "???";
            var list = new List<string>
            {
                cas,
                typeName,
                Name
            };
            return string.Join(" ", list.Where(i => !string.IsNullOrWhiteSpace(i)));
        }
    }
}
