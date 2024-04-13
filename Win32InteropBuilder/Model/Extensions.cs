using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public static class Extensions
    {
        public static FullName GetFullName(this MetadataReader reader, InterfaceImplementationHandle implementation) => reader.GetFullName(reader.GetTypeReference((TypeReferenceHandle)reader.GetInterfaceImplementation(implementation).Interface));
        public static FullName GetFullName(this MetadataReader reader, InterfaceImplementation implementation) => reader.GetFullName(reader.GetTypeReference((TypeReferenceHandle)implementation.Interface));
        public static FullName GetFullName(this MetadataReader reader, TypeReferenceHandle type) => reader.GetFullName(reader.GetTypeReference(type));
        public static FullName GetFullName(this MetadataReader reader, TypeReference type)
        {
            var ns = reader.GetString(type.Namespace);
            var name = reader.GetString(type.Name);
            return new(ns, name);
        }

        public static FullName GetFullName(this MetadataReader reader, TypeDefinitionHandle type) => reader.GetFullName(reader.GetTypeDefinition(type));
        public static FullName GetFullName(this MetadataReader reader, TypeDefinition type)
        {
            var ns = reader.GetString(type.Namespace);
            var name = reader.GetString(type.Name);
            return new(ns, name);
        }

        public static FullName? GetFullName(this MetadataReader reader, EntityHandle handle)
        {
            if (handle.IsNil)
                return null;

            switch (handle.Kind)
            {
                case HandleKind.TypeDefinition:
                    return reader.GetFullName((TypeDefinitionHandle)handle);

                case HandleKind.TypeReference:
                    return reader.GetFullName((TypeReferenceHandle)handle);

                default:
                    throw new NotSupportedException();
            }
        }

        public static MemberReference GetMemberReference(this MetadataReader reader, CustomAttribute attribute) => reader.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
        public static TypeReference GetTypeReference(this MetadataReader reader, CustomAttribute attribute) => reader.GetTypeReference((TypeReferenceHandle)reader.GetMemberReference(attribute).Parent);
        public static FullName GetFullName(this MetadataReader reader, CustomAttribute attribute) => reader.GetFullName(reader.GetTypeReference(attribute));
        public static IEnumerable<CustomAttribute> GetCustomAttributes(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            foreach (var handle in handles)
            {
                yield return reader.GetCustomAttribute(handle);
            }
        }

        public static bool IsNativeTypedef(this MetadataReader reader, TypeDefinition type) => type.GetCustomAttributes().Any(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.NativeTypedefAttribute);
        public static bool IsHandle(this MetadataReader reader, TypeDefinition type)
        {
            if (!reader.IsNativeTypedef(type))
                return false;

            var fields = type.GetFields();
            if (fields.Count != 1)
                return false;

            var field = reader.GetFieldDefinition(fields.First());
            if (!field.Attributes.HasFlag(FieldAttributes.Public) || field.Attributes.HasFlag(FieldAttributes.Static))
                return false;

            var sig = field.DecodeSignature(SignatureTypeProvider.Instance, null);
            return sig.FullName == FullName.SystemIntPtr;
        }
    }
}
