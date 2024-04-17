using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Win32InteropBuilder.Utilities;

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

        public static void SetDocumentation(this BuilderContext context, CustomAttributeHandleCollection handles, IDocumentable documentable)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(documentable);
            var handle = handles.FirstOrDefault(h => context.MetadataReader.GetFullName(context.MetadataReader.GetCustomAttribute(h)) == FullName.DocumentationAttribute);
            if (handle.IsNil)
                return;

            var value = GetValue(context, context.MetadataReader.GetCustomAttribute(handle));
            if (value.FixedArguments.Length > 0 && value.FixedArguments[0].Value is string s && !string.IsNullOrWhiteSpace(s))
            {
                documentable.Documentation = s;
            }
        }

        public static void SetSupportedOSPlatform(this BuilderContext context, CustomAttributeHandleCollection handles, ISupportable supportable)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(supportable);
            var handle = handles.FirstOrDefault(h => context.MetadataReader.GetFullName(context.MetadataReader.GetCustomAttribute(h)) == FullName.SupportedOSPlatformAttribute);
            if (handle.IsNil)
                return;

            var value = GetValue(context, context.MetadataReader.GetCustomAttribute(handle));
            if (value.FixedArguments.Length > 0 && value.FixedArguments[0].Value is string s && !string.IsNullOrWhiteSpace(s))
            {
                supportable.SupportedOSPlatform = s;
            }
        }

        public static Architecture? GetSupportedArchitecture(this BuilderContext context, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            var handle = handles.FirstOrDefault(h => context.MetadataReader.GetFullName(context.MetadataReader.GetCustomAttribute(h)) == FullName.SupportedArchitectureAttribute);
            if (handle.IsNil)
                return null;

            var value = GetValue(context, context.MetadataReader.GetCustomAttribute(handle));
            if (value.FixedArguments.Length == 1 &&
                value.FixedArguments[0].Value != null &&
                Conversions.TryChangeType<Architecture>(value.FixedArguments[0].Value, out var arch))
                return arch;

            return null;
        }

        public static CallingConvention? GetCallingConvention(this BuilderContext context, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            var handle = handles.FirstOrDefault(h => context.MetadataReader.GetFullName(context.MetadataReader.GetCustomAttribute(h)) == FullName.UnmanagedFunctionPointerAttribute);
            if (handle.IsNil)
                return null;

            var value = GetValue(context, context.MetadataReader.GetCustomAttribute(handle));
            if (value.FixedArguments.Length == 1 &&
                value.FixedArguments[0].Value != null &&
                Conversions.TryChangeType<CallingConvention>(value.FixedArguments[0].Value, out var cc))
                return cc;

            return null;
        }

        public static CustomAttributeValue<object?> GetValue(this BuilderContext context, CustomAttribute attribute)
        {
            ArgumentNullException.ThrowIfNull(context);
            return attribute.DecodeValue(context.CustomAttributeTypeProvider);
        }

        public static byte[]? GetConstantBytes(this MetadataReader reader, ConstantHandle handle)
        {
            ArgumentNullException.ThrowIfNull(reader);
            if (handle.IsNil)
                return null;

            var constant = reader.GetConstant(handle);
            return reader.GetBlobBytes(constant.Value);
        }

        public static Guid? GetInteropGuid(this BuilderContext context, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            var handle = handles.FirstOrDefault(h => context.MetadataReader.GetFullName(context.MetadataReader.GetCustomAttribute(h)) == FullName.GuidAttribute);
            if (handle.IsNil)
                return null;

            return GetInteropGuid(context, context.MetadataReader.GetCustomAttribute(handle));
        }

        public static Guid? GetInteropGuid(this BuilderContext context, CustomAttribute attribute)
        {
            ArgumentNullException.ThrowIfNull(context);
            var value = GetValue(context, attribute);
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
            if (!type.Attributes.HasFlag(TypeAttributes.Public) && !type.Attributes.HasFlag(TypeAttributes.NestedPublic))
                return false;

            var bfn = reader.GetFullName(type.BaseType);
            return bfn == FullName.SystemValueType;
        }

        public static bool IsDelegate(this MetadataReader reader, TypeDefinition type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var bfn = reader.GetFullName(type.BaseType);
            return bfn == FullName.MulticastDelegate;
        }

        public static bool IsEnum(this MetadataReader reader, TypeDefinition type)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var bfn = reader.GetFullName(type.BaseType);
            return bfn == FullName.SystemEnum;
        }

        //public static bool IsOut(this MetadataReader reader, CustomAttributeHandleCollection handles)
        //{
        //    ArgumentNullException.ThrowIfNull(reader);
        //    var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.OutAttribute);
        //    return !handle.IsNil;
        //}

        //public static bool IsIn(this MetadataReader reader, CustomAttributeHandleCollection handles)
        //{
        //    ArgumentNullException.ThrowIfNull(reader);
        //    var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.InAttribute);
        //    return !handle.IsNil;
        //}

        public static bool IsComOutPtr(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.ComOutPtrAttribute);
            return !handle.IsNil;
        }

        public static bool IsConst(this MetadataReader reader, CustomAttributeHandleCollection handles)
        {
            ArgumentNullException.ThrowIfNull(reader);
            var handle = handles.FirstOrDefault(h => reader.GetFullName(reader.GetCustomAttribute(h)) == FullName.ConstAttribute);
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
