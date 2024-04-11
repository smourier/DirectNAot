using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Win32MetadataReader
{
    public class SignatureTypeProvider : ISignatureTypeProvider<ParsedType, object?>
    {
        public static readonly SignatureTypeProvider Instance = new SignatureTypeProvider();

        private SignatureTypeProvider()
        {
        }

        public ParsedType GetArrayType(ParsedType elementType, ArrayShape shape) => new ParsedType(elementType.FullName) { ArrayShape = shape };
        public ParsedType GetPointerType(ParsedType elementType) => new ParsedType(elementType.FullName) { Indirections = elementType.Indirections + 1 };
        public ParsedType GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind) => new ParsedType(reader.GetFullName(reader.GetTypeDefinition(handle)));
        public ParsedType GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind) => new ParsedType(reader.GetFullName(reader.GetTypeReference(handle)));
        public ParsedType GetPrimitiveType(PrimitiveTypeCode typeCode)
        {
            switch (typeCode)
            {
                case PrimitiveTypeCode.UInt32:
                    return new ParsedType(typeof(uint));

                case PrimitiveTypeCode.Void:
                    return new ParsedType(typeof(void));

                case PrimitiveTypeCode.Boolean:
                    return new ParsedType(typeof(bool));

                case PrimitiveTypeCode.Char:
                    return new ParsedType(typeof(char));

                case PrimitiveTypeCode.SByte:
                    return new ParsedType(typeof(sbyte));

                case PrimitiveTypeCode.Byte:
                    return new ParsedType(typeof(byte));

                case PrimitiveTypeCode.Int16:
                    return new ParsedType(typeof(short));

                case PrimitiveTypeCode.UInt16:
                    return new ParsedType(typeof(ushort));

                case PrimitiveTypeCode.Int32:
                    return new ParsedType(typeof(int));

                case PrimitiveTypeCode.Int64:
                    return new ParsedType(typeof(long));

                case PrimitiveTypeCode.UInt64:
                    return new ParsedType(typeof(ulong));

                case PrimitiveTypeCode.Single:
                    return new ParsedType(typeof(float));

                case PrimitiveTypeCode.Double:
                    return new ParsedType(typeof(double));

                case PrimitiveTypeCode.String:
                    return new ParsedType(typeof(string));

                case PrimitiveTypeCode.IntPtr:
                    return new ParsedType(typeof(nint));

                case PrimitiveTypeCode.UIntPtr:
                    return new ParsedType(typeof(nuint));
            }

            throw new NotSupportedException();
        }

        public ParsedType GetTypeFromSpecification(MetadataReader reader, object? genericContext, TypeSpecificationHandle handle, byte rawTypeKind) => throw new NotImplementedException();
        public ParsedType GetSZArrayType(ParsedType elementType) => throw new NotImplementedException();
        public ParsedType GetByReferenceType(ParsedType elementType) => throw new NotImplementedException();
        public ParsedType GetFunctionPointerType(MethodSignature<ParsedType> signature) => throw new NotImplementedException();
        public ParsedType GetGenericInstantiation(ParsedType genericType, ImmutableArray<ParsedType> typeArguments) => throw new NotImplementedException();
        public ParsedType GetGenericMethodParameter(object? genericContext, int index) => throw new NotImplementedException();
        public ParsedType GetGenericTypeParameter(object? genericContext, int index) => throw new NotImplementedException();
        public ParsedType GetModifiedType(ParsedType modifier, ParsedType unmodifiedType, bool isRequired) => throw new NotImplementedException();
        public ParsedType GetPinnedType(ParsedType elementType) => throw new NotImplementedException();
    }
}
