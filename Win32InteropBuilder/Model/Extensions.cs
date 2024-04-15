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
        public static FullName GetFullName(this MetadataReader reader, InterfaceImplementationHandle implementation)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetFullName(reader.GetTypeReference((TypeReferenceHandle)reader.GetInterfaceImplementation(implementation).Interface));
        }

        public static FullName GetFullName(this MetadataReader reader, InterfaceImplementation implementation)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetFullName(reader.GetTypeReference((TypeReferenceHandle)implementation.Interface));
        }

        public static FullName GetFullName(this MetadataReader reader, TypeReferenceHandle type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetFullName(reader.GetTypeReference(type));
        }

        public static FullName GetFullName(this MetadataReader reader, TypeReference type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var ns = reader.GetString(type.Namespace);
            var name = reader.GetString(type.Name);
            return new(ns, name);
        }

        public static FullName GetFullName(this MetadataReader reader, TypeDefinitionHandle type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetFullName(reader.GetTypeDefinition(type));
        }

        public static FullName GetFullName(this MetadataReader reader, TypeDefinition type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var ns = reader.GetString(type.Namespace);
            var name = reader.GetString(type.Name);
            return new(ns, name);
        }

        public static FullName? GetFullName(this MetadataReader reader, EntityHandle handle)
        {
            ArgumentNullException.ThrowIfNull(reader);
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

        public static MemberReference GetMemberReference(this MetadataReader reader, CustomAttribute attribute)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
        }

        public static TypeReference GetTypeReference(this MetadataReader reader, CustomAttribute attribute)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetTypeReference((TypeReferenceHandle)reader.GetMemberReference(attribute).Parent);
        }

        public static FullName GetFullName(this MetadataReader reader, CustomAttribute attribute)
        {
            ArgumentNullException.ThrowIfNull(reader);
            return reader.GetFullName(reader.GetTypeReference(attribute));
        }

        public static IReadOnlyList<FullName> GetCustomAttributesFullNames(this MetadataReader reader, CustomAttributeHandleCollection handles) => GetCustomAttributes(reader, handles).Select(reader.GetFullName).ToArray();
        public static IEnumerable<CustomAttribute> GetCustomAttributes(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            foreach (var handle in handles)
            {
                yield return reader.GetCustomAttribute(handle);
            }
        }

        public static void SetDocumentation(this MetadataReader reader, CustomAttributeHandleCollection handles, IDocumentable documentable)
        {
            ArgumentNullException.ThrowIfNull(reader);
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

        public static void SetSupportedOSPlatform(this MetadataReader reader, CustomAttributeHandleCollection handles, ISupportable supportable)
        {
            ArgumentNullException.ThrowIfNull(reader);
            ArgumentNullException.ThrowIfNull(supportable);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.SupportedOSPlatformAttribute);
            if (handle.IsNil)
                return;

            var value = GetValue(reader.GetCustomAttribute(handle));
            if (value.FixedArguments.Length > 0 && value.FixedArguments[0].Value is string s && !string.IsNullOrWhiteSpace(s))
            {
                supportable.SupportedOSPlatform = s;
            }
        }

        public static CustomAttributeValue<object?> GetValue(CustomAttribute attribute) => attribute.DecodeValue(CustomAttributeTypeProvider.Instance);

        public static byte[]? GetConstantBytes(this MetadataReader reader, ConstantHandle handle)
        {
            ArgumentNullException.ThrowIfNull(reader);
            if (handle.IsNil)
                return null;

            var constant = reader.GetConstant(handle);
            return reader.GetBlobBytes(constant.Value);
        }

        public static Guid? GetInteropGuid(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.GuidAttribute);
            if (handle.IsNil)
                return null;

            return GetInteropGuid(reader.GetCustomAttribute(handle));
        }

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
        public static bool IsHandle(this MetadataReader reader, TypeDefinition type, SignatureTypeProvider signatureTypeProvider)
        {
            ArgumentNullException.ThrowIfNull(reader);
            ArgumentNullException.ThrowIfNull(signatureTypeProvider);
            if (!reader.IsNativeTypedef(type))
                return false;

            var fields = type.GetFields();
            if (fields.Count != 1)
                return false;

            var field = reader.GetFieldDefinition(fields.First());
            if (!field.Attributes.HasFlag(FieldAttributes.Public) || field.Attributes.HasFlag(FieldAttributes.Static))
                return false;

            var sig = field.DecodeSignature(signatureTypeProvider, null);
            return sig.FullName == FullName.SystemIntPtr;
        }

        public static bool IsStructure(this MetadataReader reader, TypeDefinition type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            if (!type.Attributes.HasFlag(TypeAttributes.Public | TypeAttributes.SequentialLayout))
                return false;

            var bfn = reader.GetFullName(type.BaseType);
            return bfn == FullName.SystemValueType;
        }

        public static bool IsEnum(this MetadataReader reader, TypeDefinition type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var bfn = reader.GetFullName(type.BaseType);
            return bfn == FullName.SystemEnum;
        }

        public static bool IsOut(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.OutAttribute);
            return !handle.IsNil;
        }

        public static bool IsComOutPtr(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.ComOutPtrAttribute);
            return !handle.IsNil;
        }

        public static bool IsAnsi(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.AnsiAttribute);
            return !handle.IsNil;
        }

        public static bool IsUnicode(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.UnicodeAttribute);
            return !handle.IsNil;
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
