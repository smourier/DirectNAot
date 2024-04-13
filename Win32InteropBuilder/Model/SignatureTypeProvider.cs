using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class SignatureTypeProvider : ISignatureTypeProvider<BuilderType, object?>
    {
        public SignatureTypeProvider(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            Context = context;
        }

        public BuilderContext Context { get; }

        public virtual BuilderType GetArrayType(BuilderType elementType, ArrayShape shape)
        {
            ArgumentNullException.ThrowIfNull(elementType);
            var type = elementType.Clone(Context);
            type.ArrayShape = shape;
            return type;
        }

        public virtual BuilderType GetPointerType(BuilderType elementType)
        {
            ArgumentNullException.ThrowIfNull(elementType);
            var type = elementType.Clone(Context);
            type.Indirections = elementType.Indirections + 1;
            return type;
        }

        public virtual BuilderType GetTypeFromDefinition(MetadataReader reader, TypeDefinitionHandle handle, byte rawTypeKind)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var typeDef = reader.GetTypeDefinition(handle);
            var fn = reader.GetFullName(typeDef);
            return Context.AllTypes[fn];
        }

        public virtual BuilderType GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var typeRef = reader.GetTypeReference(handle);
            var fn = reader.GetFullName(typeRef);
            return Context.AllTypes[fn];
        }

        public virtual BuilderType GetPrimitiveType(PrimitiveTypeCode typeCode)
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

        public virtual BuilderType GetTypeFromSpecification(MetadataReader reader, object? genericContext, TypeSpecificationHandle handle, byte rawTypeKind) => throw new NotImplementedException();
        public virtual BuilderType GetSZArrayType(BuilderType elementType) => throw new NotImplementedException();
        public virtual BuilderType GetByReferenceType(BuilderType elementType) => throw new NotImplementedException();
        public virtual BuilderType GetFunctionPointerType(MethodSignature<BuilderType> signature) => throw new NotImplementedException();
        public virtual BuilderType GetGenericInstantiation(BuilderType genericType, ImmutableArray<BuilderType> typeArguments) => throw new NotImplementedException();
        public virtual BuilderType GetGenericMethodParameter(object? genericContext, int index) => throw new NotImplementedException();
        public virtual BuilderType GetGenericTypeParameter(object? genericContext, int index) => throw new NotImplementedException();
        public virtual BuilderType GetModifiedType(BuilderType modifier, BuilderType unmodifiedType, bool isRequired) => throw new NotImplementedException();
        public virtual BuilderType GetPinnedType(BuilderType elementType) => throw new NotImplementedException();
    }
}
