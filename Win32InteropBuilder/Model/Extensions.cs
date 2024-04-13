using System;
using System.Collections.Generic;
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

        public static IEnumerable<CustomAttribute> GetCustomAttributes(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            foreach (var handle in handles)
            {
                yield return reader.GetCustomAttribute(handle);
            }
        }
    }
}
