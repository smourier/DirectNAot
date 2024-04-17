using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using Win32InteropBuilder.Utilities;

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
            if (shape.Rank == 1 && shape.Sizes.Length == 1)
            {
                var arrayType = Context.CreateInlineArrayType(elementType, shape.Sizes[0]);
                Context.TypesToBuild.Add(arrayType);
                return arrayType;
            }

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
            var fn = Context.GetFullName(typeDef);
            return Context.AllTypes[fn];
        }

        public virtual BuilderType GetTypeFromReference(MetadataReader reader, TypeReferenceHandle handle, byte rawTypeKind)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var typeRef = reader.GetTypeReference(handle);
            var fn = reader.GetFullName(typeRef);
            if (Context.AllTypes.TryGetValue(fn, out var type))
                return type;

            // check anonymous embedded types
            if (fn.Namespace == string.Empty && Context.CurrentTypes.Count > 0)
            {
                var currentType = Context.CurrentTypes.Peek();
                var nestedType = currentType.NestedTypes.FirstOrDefault(t => t.FullName.NestedName == fn.Name);
                if (nestedType != null)
                    return nestedType;
            }
            throw new EnumBasedException<Win32InteropBuilderExceptionCode>(Win32InteropBuilderExceptionCode.CantResolveType, $"Full name: {fn}");
        }

        public virtual BuilderType GetPrimitiveType(PrimitiveTypeCode typeCode)
        {
            switch (typeCode)
            {
                case PrimitiveTypeCode.UInt32:
                    return WellKnownTypes.SystemUInt32;

                case PrimitiveTypeCode.Void:
                    return WellKnownTypes.SystemVoid;

                case PrimitiveTypeCode.Boolean:
                    return WellKnownTypes.SystemBoolean;

                case PrimitiveTypeCode.Char:
                    return WellKnownTypes.SystemChar;

                case PrimitiveTypeCode.SByte:
                    return WellKnownTypes.SystemSByte;

                case PrimitiveTypeCode.Byte:
                    return WellKnownTypes.SystemByte;

                case PrimitiveTypeCode.Int16:
                    return WellKnownTypes.SystemInt16;

                case PrimitiveTypeCode.UInt16:
                    return WellKnownTypes.SystemUInt16;

                case PrimitiveTypeCode.Int32:
                    return WellKnownTypes.SystemInt32;

                case PrimitiveTypeCode.Int64:
                    return WellKnownTypes.SystemInt64;

                case PrimitiveTypeCode.UInt64:
                    return WellKnownTypes.SystemUInt64;

                case PrimitiveTypeCode.Single:
                    return WellKnownTypes.SystemSingle;

                case PrimitiveTypeCode.Double:
                    return WellKnownTypes.SystemDouble;

                case PrimitiveTypeCode.String:
                    return WellKnownTypes.SystemString;

                case PrimitiveTypeCode.IntPtr:
                    return WellKnownTypes.SystemIntPtr;

                case PrimitiveTypeCode.UIntPtr:
                    return WellKnownTypes.SystemUIntPtr;

                case PrimitiveTypeCode.Object:
                    return WellKnownTypes.SystemObject;
            }

            throw new NotSupportedException();
        }

        public virtual BuilderType GetTypeFromSpecification(MetadataReader reader, object? genericContext, TypeSpecificationHandle handle, byte rawTypeKind) => throw new NotSupportedException();
        public virtual BuilderType GetSZArrayType(BuilderType elementType) => throw new NotSupportedException();
        public virtual BuilderType GetByReferenceType(BuilderType elementType) => throw new NotSupportedException();
        public virtual BuilderType GetFunctionPointerType(MethodSignature<BuilderType> signature) => throw new NotSupportedException();
        public virtual BuilderType GetGenericInstantiation(BuilderType genericType, ImmutableArray<BuilderType> typeArguments) => throw new NotSupportedException();
        public virtual BuilderType GetGenericMethodParameter(object? genericContext, int index) => throw new NotSupportedException();
        public virtual BuilderType GetGenericTypeParameter(object? genericContext, int index) => throw new NotSupportedException();
        public virtual BuilderType GetModifiedType(BuilderType modifier, BuilderType unmodifiedType, bool isRequired) => throw new NotSupportedException();
        public virtual BuilderType GetPinnedType(BuilderType elementType) => throw new NotSupportedException();
    }
}
