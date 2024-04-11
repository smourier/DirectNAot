using System;
using System.Reflection.Metadata;

namespace Win32MetadataReader
{
    public class CustomAttributeTypeProvider : ICustomAttributeTypeProvider<object?>
    {
        public static readonly CustomAttributeTypeProvider Instance = new CustomAttributeTypeProvider();

        private CustomAttributeTypeProvider()
        {
        }

        public object? GetPrimitiveType(PrimitiveTypeCode typeCode) => null;
        public object GetSystemType() => throw new NotImplementedException();
        public object GetSZArrayType(object? elementType) => throw new NotImplementedException();
        public object GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind) => throw new NotImplementedException();
        public object GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind) => throw new NotImplementedException();
        public object GetTypeFromSerializedName(string name) => throw new NotImplementedException();
        public PrimitiveTypeCode GetUnderlyingEnumType(object? type) => throw new NotImplementedException();
        public bool IsSystemType(object? type) => throw new NotImplementedException();
    }
}
