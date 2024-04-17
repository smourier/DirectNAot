using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder.Model
{
    public class BuilderType : IEquatable<BuilderType>, IDocumentable, ISupportable, IComparable, IComparable<BuilderType>
    {
        public const string GeneratedInteropNamespace = "System.Runtime.InteropServices.InteropTypes";

        private readonly List<BuilderMethod> _methods = [];
        private readonly List<BuilderField> _fields = [];
        private readonly List<BuilderType> _interfaces = [];
        private readonly List<BuilderType> _nestedTypes = [];

        public BuilderType(FullName fullName)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            FullName = fullName;
        }

        public BuilderType(Type type)
            : this(new FullName(type))
        {
            ArgumentNullException.ThrowIfNull(type);
            ClrType = type;
        }

        public FullName FullName { get; }
        public BuilderType? BaseType { get; set; }
        public virtual BuilderType? DeclaringType { get; set; }
        public virtual Type? ClrType { get; set; }
        public virtual TypeAttributes TypeAttributes { get; set; }
        public virtual bool IsGenerated { get; set; } = true;
        public virtual int Indirections { get; set; }
        public virtual ArrayShape? ArrayShape { get; set; }
        public virtual IList<BuilderMethod> Methods => _methods;
        public virtual IList<BuilderField> Fields => _fields;
        public virtual IList<BuilderType> Interfaces => _interfaces;
        public virtual IList<BuilderType> NestedTypes => _nestedTypes;
        public virtual string? Documentation { get; set; }
        public virtual string? SupportedOSPlatform { get; set; }
        public virtual Guid? Guid { get; set; }
        public virtual string FileName => FullName.Name;
        public virtual UnmanagedType? UnmanagedType { get; set; }
        public virtual PrimitiveTypeCode PrimitiveTypeCode { get; set; } = PrimitiveTypeCode.Object;

        public virtual bool IsConstableType() => FullName.IsConstableType(FullName);

        public virtual void ResolveType(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            Guid = context.GetInteropGuid(typeDef.GetCustomAttributes());
            TypeAttributes = typeDef.Attributes;
            context.TypesToBuild.Add(this);

            context.CurrentTypes.Push(this);
            try
            {
                var baseTypeHandle = typeDef.BaseType;
                if (!baseTypeHandle.IsNil)
                {
                    if (baseTypeHandle.Kind == HandleKind.TypeReference)
                    {
                        var baseTypeDef = context.MetadataReader.GetTypeReference((TypeReferenceHandle)baseTypeHandle);
                        var fn = context.MetadataReader.GetFullName(baseTypeDef);
                        BaseType = context.AllTypes[fn];
                    }
                    else
                        throw new NotSupportedException();
                }

                context.SetDocumentation(typeDef.GetCustomAttributes(), this);
                context.SetSupportedOSPlatform(typeDef.GetCustomAttributes(), this);

                ResolveNestedTypes(context, typeDef);
                ResolveMethods(context, typeDef);
                ResolveInterfaces(context, typeDef);
                ResolveFields(context, typeDef);
            }
            finally
            {
                if (context.CurrentTypes.Pop() != this)
                    throw new InvalidOperationException();
            }
        }

        public virtual void ResolveNestedTypes(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            foreach (var handle in typeDef.GetNestedTypes())
            {
                var nestedDef = context.MetadataReader.GetTypeDefinition(handle);
                var nestedType = context.CreateBuilderType(nestedDef);
                if (nestedType == null)
                    continue;

                nestedType.IsGenerated = false;
                context.CurrentTypes.Push(nestedType);
                try
                {
                    if (!context.TypesToBuild.TryGetValue(nestedType, out var existing))
                    {
                        existing = nestedType;
                        context.AddDependencies(existing);
                    }

                    NestedTypes.Add(existing);

                }
                finally
                {
                    if (context.CurrentTypes.Pop() != nestedType)
                        throw new InvalidOperationException();
                }
            }
        }

        public virtual void ResolveMethods(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            foreach (var handle in typeDef.GetMethods())
            {
                var methodDef = context.MetadataReader.GetMethodDefinition(handle);
                var method = context.CreateBuilderMethod(context.MetadataReader.GetString(methodDef.Name));
                method.Attributes = methodDef.Attributes;
                method.ImplAttributes = methodDef.ImplAttributes;
                method.IsAnsi = context.MetadataReader.IsAnsi(methodDef.GetCustomAttributes());
                method.IsUnicode = context.MetadataReader.IsUnicode(methodDef.GetCustomAttributes());

                if (method.Attributes.HasFlag(MethodAttributes.PinvokeImpl))
                {
                    var ca = context.MetadataReader.GetCustomAttributes(methodDef.GetCustomAttributes());

                    var import = methodDef.GetImport();
                    method.ImportAttributes = import.Attributes;
                    method.ImportEntryPoint = context.MetadataReader.GetString(import.Name);
                    var module = context.MetadataReader.GetModuleReference(import.Module);
                    method.ImportModuleName = context.MetadataReader.GetString(module.Name);
                }

                context.SetSupportedOSPlatform(methodDef.GetCustomAttributes(), method);
                context.SetDocumentation(methodDef.GetCustomAttributes(), method);

                Methods.Add(method);
                foreach (var phandle in methodDef.GetParameters())
                {
                    var parameterDef = context.MetadataReader.GetParameter(phandle);
                    var parameter = context.CreateBuilderParameter(context.MetadataReader.GetString(parameterDef.Name), parameterDef.SequenceNumber);
                    // remove 'this'
                    if (string.IsNullOrEmpty(parameter.Name) && parameter.SequenceNumber == 0)
                        continue;

                    parameter.Attributes = parameterDef.Attributes;
                    parameter.IsComOutPtr = context.MetadataReader.IsComOutPtr(parameterDef.GetCustomAttributes());
                    parameter.IsConst = context.MetadataReader.IsConst(parameterDef.GetCustomAttributes());

                    method.Parameters.Add(parameter);
                }
                method.SortParameters();

                var dec = methodDef.DecodeSignature(context.SignatureTypeProvider, null);
                method.ReturnType = dec.ReturnType;
                if (method.ReturnType != null)
                {
                    context.AddDependencies(method.ReturnType);
                }

                if (method.Parameters.Count != dec.ParameterTypes.Length)
                    throw new InvalidOperationException();

                for (var i = 0; i < method.Parameters.Count; i++)
                {
                    method.Parameters[i].Type = dec.ParameterTypes[i];
                    if (method.Parameters[i].Type == null)
                        throw new InvalidOperationException();

                    context.AddDependencies(method.Parameters[i].Type!);
                }
            }
        }

        public virtual void ResolveInterfaces(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            var interfaces = typeDef.GetInterfaceImplementations();
            foreach (var iface in interfaces)
            {
                var fn = context.MetadataReader.GetFullName(iface);
                if (fn == FullName.IUnknown && this is InterfaceType ifaceType)
                {
                    ifaceType.IsIUnknownDerived = true;
                    continue;
                }

                var typeRefType = context.AllTypes[fn];
                context.AddDependencies(typeRefType);
                Interfaces.Add(typeRefType);
            }
        }

        public virtual void ResolveFields(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            foreach (var handle in typeDef.GetFields())
            {
                var fieldDef = context.MetadataReader.GetFieldDefinition(handle);
                var name = context.MetadataReader.GetString(fieldDef.Name);
                var field = context.CreateBuilderField(name, fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                field.Attributes = fieldDef.Attributes;
                field.DefaultValueAsBytes = context.MetadataReader.GetConstantBytes(fieldDef.GetDefaultValue());

                var offset = fieldDef.GetOffset();
                if (offset >= 0)
                {
                    field.Offset = offset;
                }

                // bit of a hack for guids
                if (field.DefaultValueAsBytes == null && field.Type.FullName == WellKnownTypes.SystemGuid.FullName)
                {
                    var guid = context.GetInteropGuid(fieldDef.GetCustomAttributes());
                    if (guid.HasValue)
                    {
                        field.DefaultValueAsBytes = guid.Value.ToByteArray();
                    }
                }

                Fields.Add(field);
                context.AddDependencies(field.Type);
            }
        }

        public virtual string GetGeneratedName(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.MappedTypes.TryGetValue(FullName, out var mappedType) && mappedType != this)
                return mappedType.GetGeneratedName(context);

            var un = context.Configuration.GetGeneration();
            if (WellKnownTypes.All.TryGetValue(FullName, out var type))
            {
                if (context.ImplicitNamespaces.Contains(type.FullName.Namespace))
                    return FullName.Name;

                if (type.FullName.Namespace == context.CurrentNamespace)
                    return type.FullName.Name;

                if (un != null)
                    return type.FullName.Name;

                return type.FullName.ToString();
            }

            var nested = FullName.NestedName;
            if (nested != null)
                return nested;

            if (context.ImplicitNamespaces.Contains(FullName.Namespace))
                return FullName.Name;

            if (FullName.Namespace == context.CurrentNamespace)
                return FullName.Name;

            if (un != null)
                return FullName.Name;

            return ToString();
        }

        protected virtual void SortCollections()
        {
            if (this is not InterfaceType)
            {
                _methods.Sort();
            }

            if (this is not StructureType && this is not EnumType)
            {
                _fields.Sort();
            }

            _interfaces.Sort();
            _nestedTypes.Sort();
        }

        public virtual void Generate(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.OutputDirectoryPath);

            SortCollections();

            if (GetType() == typeof(BuilderType))
            {
                // base type handling only (including constants & functions)
                var un = context.Configuration.GetGeneration();
                if (un != null)
                {
                    var ico = isConstants();
                    var ifu = isFunctions();
                    if (!ico && !ifu)
                    {
                        if (un.ConstantsFileName != null)
                        {
                            context.ConstantsTypes.Add(this);
                        }

                        if (un.FunctionsFileName != null)
                        {
                            context.FunctionsTypes.Add(this);
                        }

                        // nothing to do here?
                        if (un.ConstantsFileName != null && un.FunctionsFileName != null)
                            return;
                    }

                    bool isConstants() => FullName.Namespace == un.Namespace && FullName.Name == un.ConstantsFileName;
                    bool isFunctions() => FullName.Namespace == un.Namespace && FullName.Name == un.FunctionsFileName;
                }
            }

            using var writer = new StringWriter();
            context.CurrentWriter = new IndentedTextWriter(writer);
            try
            {
                GenerateCode(context);
            }
            finally
            {
                context.CurrentWriter.Dispose();
                context.CurrentWriter = null;
            }

            var ns = context.MapGeneratedFullName(FullName).Namespace.Replace('.', Path.DirectorySeparatorChar);
            var text = writer.ToString();
            var fileName = FileName + context.Language.FileExtension;
            var typePath = Path.Combine(context.Configuration.OutputDirectoryPath, ns, fileName);
            if (IOUtilities.PathIsFile(typePath))
            {
                var existingText = EncodingDetector.ReadAllText(typePath, context.Configuration.EncodingDetectorMode, out _);
                if (text == existingText)
                {
                    context.ExistingFiles.Remove(typePath);
                    return;
                }
            }

            IOUtilities.FileEnsureDirectory(typePath);
            File.WriteAllText(typePath, text, context.Configuration.FinalOutputEncoding);
            context.ExistingFiles.Remove(typePath);
        }

        public virtual void GenerateCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Language);
            context.Language.GenerateCode(context, this);
        }

        public virtual BuilderType CloneType(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (this is InterfaceType)
                return context.CreateInterfaceType(FullName);

            if (this is InlineArrayType at)
                return context.CreateInlineArrayType(at.ElementType, at.Size);

            if (this is DelegateType)
                return context.CreateDelegateType(FullName);

            if (this is StructureType)
                return context.CreateStructureType(FullName);

            if (this is EnumType)
                return context.CreateEnumType(FullName);

            return context.CreateBuilderType(FullName);
        }

        public virtual BuilderType Clone(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            var clone = CloneType(context);
            CopyTo(clone);
            return clone;
        }

        protected virtual void CopyTo(BuilderType copy)
        {
            ArgumentNullException.ThrowIfNull(copy);
            if (copy == this)
                return;

            copy.BaseType = BaseType;
            copy.DeclaringType = DeclaringType;
            copy.TypeAttributes = TypeAttributes;
            copy.IsGenerated = IsGenerated;
            copy.Indirections = Indirections;
            copy.ArrayShape = ArrayShape;
            copy.Methods.AddRange(Methods);
            copy.Fields.AddRange(Fields);
            copy.Interfaces.AddRange(Interfaces);
            copy.NestedTypes.AddRange(NestedTypes);
            copy.Documentation = Documentation;
            copy.SupportedOSPlatform = SupportedOSPlatform;
            copy.Guid = Guid;
            copy.UnmanagedType = UnmanagedType;
        }

        public object? GetValue(byte[]? bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            if (bytes.Length == 4 && FullName == WellKnownTypes.SystemInt32.FullName)
                return BitConverter.ToInt32(bytes, 0);

            if (bytes.Length == 4 && FullName == WellKnownTypes.SystemUInt32.FullName)
                return BitConverter.ToUInt32(bytes, 0);

            if (bytes.Length == 2 && FullName == WellKnownTypes.SystemInt16.FullName)
                return BitConverter.ToInt16(bytes, 0);

            if (bytes.Length == 2 && FullName == WellKnownTypes.SystemUInt16.FullName)
                return BitConverter.ToUInt16(bytes, 0);

            if (bytes.Length == 8 && FullName == WellKnownTypes.SystemInt64.FullName)
                return BitConverter.ToInt64(bytes, 0);

            if (bytes.Length == 8 && FullName == WellKnownTypes.SystemUInt64.FullName)
                return BitConverter.ToUInt64(bytes, 0);

            // we currently presume all enums are Int32...
            if (bytes.Length == 4 && this is EnumType)
                return BitConverter.ToInt32(bytes, 0);

            if (bytes.Length == 16 && FullName == WellKnownTypes.SystemGuid.FullName)
                return new Guid(bytes);

            if (this is StructureType structureType && structureType.Fields.Count == 1)
                return structureType.Fields[0].Type.GetValue(bytes);

            if (this is EnumType enumType)
            {
                if (enumType.UnderlyingType != null)
                    return enumType.UnderlyingType.GetValue(bytes);
            }

            throw new NotSupportedException();
        }

        public override int GetHashCode() => FullName.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as BuilderType);
        public bool Equals(BuilderType? other) => other != null && other.FullName == FullName;
        public override string ToString() => FullName.ToString();

        int IComparable.CompareTo(object? obj) => CompareTo(obj as BuilderType);
        public int CompareTo(BuilderType? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            if (FullName.Namespace == other.FullName.Namespace)
                return FullName.Name.CompareTo(other.FullName.Name);

            return FullName.Namespace.CompareTo(other.FullName.Namespace);
        }
    }
}
