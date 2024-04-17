using System;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class CustomAttributeTypeProvider : ICustomAttributeTypeProvider<object?>
    {
        public CustomAttributeTypeProvider(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            Context = context;
        }

        public BuilderContext Context { get; }

        public object? GetPrimitiveType(PrimitiveTypeCode typeCode) => null;
        public object GetSystemType() => throw new NotSupportedException();
        public object GetSZArrayType(object? elementType) => throw new NotSupportedException();
        public object GetTypeFromSerializedName(string name) => throw new NotSupportedException();

        public PrimitiveTypeCode GetUnderlyingEnumType(object? type)
        {
            if (type is EnumType enumType)
            {
                if (enumType.UnderlyingType != null)
                    return enumType.UnderlyingType.PrimitiveTypeCode;

                return PrimitiveTypeCode.Int32;
            }

            throw new NotSupportedException();
        }

        public bool IsSystemType(object? type) => false;

        public virtual object GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var typeDef = reader.GetTypeDefinition(handle);
            var fn = Context.GetFullName(typeDef);
            return Context.AllTypes[fn];
        }

        public virtual object GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var typeRef = reader.GetTypeReference(handle);
            var fn = reader.GetFullName(typeRef);
            return Context.AllTypes[fn];
        }
    }
}
