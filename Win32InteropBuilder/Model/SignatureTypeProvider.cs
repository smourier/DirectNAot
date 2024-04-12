using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class SignatureTypeProvider : ISignatureTypeProvider<BuilderType, object?>
    {
        public static SignatureTypeProvider Instance { get; } = new();

        private SignatureTypeProvider()
        {
        }

        public BuilderType GetArrayType(BuilderType elementType, ArrayShape shape) => new(elementType.FullName) { ArrayShape = shape };
        public BuilderType GetPointerType(BuilderType elementType) => new(elementType.FullName) { Indirections = elementType.Indirections + 1 };
        public BuilderType GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind) => new(reader.GetFullName(reader.GetTypeDefinition(handle)));
        public BuilderType GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind) => new(reader.GetFullName(reader.GetTypeReference(handle)));
        public BuilderType GetPrimitiveType(PrimitiveTypeCode typeCode)
        {
            switch (typeCode)
            {
                case PrimitiveTypeCode.UInt32:
                    return new BuilderType(typeof(uint));

                case PrimitiveTypeCode.Void:
                    return new BuilderType(typeof(void));

                case PrimitiveTypeCode.Boolean:
                    return new BuilderType(typeof(bool));

                case PrimitiveTypeCode.Char:
                    return new BuilderType(typeof(char));

                case PrimitiveTypeCode.SByte:
                    return new BuilderType(typeof(sbyte));

                case PrimitiveTypeCode.Byte:
                    return new BuilderType(typeof(byte));

                case PrimitiveTypeCode.Int16:
                    return new BuilderType(typeof(short));

                case PrimitiveTypeCode.UInt16:
                    return new BuilderType(typeof(ushort));

                case PrimitiveTypeCode.Int32:
                    return new BuilderType(typeof(int));

                case PrimitiveTypeCode.Int64:
                    return new BuilderType(typeof(long));

                case PrimitiveTypeCode.UInt64:
                    return new BuilderType(typeof(ulong));

                case PrimitiveTypeCode.Single:
                    return new BuilderType(typeof(float));

                case PrimitiveTypeCode.Double:
                    return new BuilderType(typeof(double));

                case PrimitiveTypeCode.String:
                    return new BuilderType(typeof(string));

                case PrimitiveTypeCode.IntPtr:
                    return new BuilderType(typeof(nint));

                case PrimitiveTypeCode.UIntPtr:
                    return new BuilderType(typeof(nuint));
            }

            throw new NotSupportedException();
        }

        public BuilderType GetTypeFromSpecification(MetadataReader reader, object? genericContext, TypeSpecificationHandle handle, byte rawTypeKind) => throw new NotImplementedException();
        public BuilderType GetSZArrayType(BuilderType elementType) => throw new NotImplementedException();
        public BuilderType GetByReferenceType(BuilderType elementType) => throw new NotImplementedException();
        public BuilderType GetFunctionPointerType(MethodSignature<BuilderType> signature) => throw new NotImplementedException();
        public BuilderType GetGenericInstantiation(BuilderType genericType, ImmutableArray<BuilderType> typeArguments) => throw new NotImplementedException();
        public BuilderType GetGenericMethodParameter(object? genericContext, int index) => throw new NotImplementedException();
        public BuilderType GetGenericTypeParameter(object? genericContext, int index) => throw new NotImplementedException();
        public BuilderType GetModifiedType(BuilderType modifier, BuilderType unmodifiedType, bool isRequired) => throw new NotImplementedException();
        public BuilderType GetPinnedType(BuilderType elementType) => throw new NotImplementedException();
    }
}
