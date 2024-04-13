using System;
using System.CodeDom.Compiler;
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

        public static void SetDocumentation(this MetadataReader reader, CustomAttributeHandleCollection handles, IDocumentable documentable)
        {
            ArgumentNullException.ThrowIfNull(documentable);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.DocumentationAttribute);
            if (handle.IsNil)
                return;

            var value = GetValue(reader.GetCustomAttribute(handle));
            if (value.FixedArguments.Length > 0 && value.FixedArguments[0].Value is string s && !string.IsNullOrWhiteSpace(s))
            {
                documentable.Documentation = s;
            }
        }

        public static CustomAttributeValue<object?> GetValue(CustomAttribute attribute) => attribute.DecodeValue(CustomAttributeTypeProvider.Instance);
        public static Guid? GetInteropGuid(CustomAttribute attribute)
        {
            var value = GetValue(attribute);
            if (value.FixedArguments.Length != 11)
                return null;

#pragma warning disable CS8605 // Unboxing a possibly null value.
            return new Guid(
                (uint)value.FixedArguments[0].Value,
                (ushort)value.FixedArguments[1].Value,
                (ushort)value.FixedArguments[2].Value,
                (byte)value.FixedArguments[3].Value,
                (byte)value.FixedArguments[4].Value,
                (byte)value.FixedArguments[5].Value,
                (byte)value.FixedArguments[6].Value,
                (byte)value.FixedArguments[7].Value,
                (byte)value.FixedArguments[8].Value,
                (byte)value.FixedArguments[9].Value,
                (byte)value.FixedArguments[10].Value);
#pragma warning restore CS8605 // Unboxing a possibly null value.
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

        public static void WithParens(this IndentedTextWriter writer, Action action)
        {
            ArgumentNullException.ThrowIfNull(writer);
            ArgumentNullException.ThrowIfNull(action);
            writer.WriteLine('{');
            writer.Indent++;
            action();
            writer.Indent--;
            writer.WriteLine('}');
        }
    }
}
