using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
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
        }

        public FullName FullName { get; }
        public BuilderType? BaseType { get; set; }
        public virtual BuilderType? DeclaringType { get; set; }
        public virtual TypeAttributes TypeAttributes { get; set; }
        public virtual bool IsGenerated { get; set; } = true;
        public virtual bool IsStructure { get; set; }
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
        public virtual string? GeneratedName { get; set; }
        public virtual UnmanagedType? UnmanagedType { get; set; }
        public virtual PrimitiveTypeCode PrimitiveTypeCode { get; set; } = PrimitiveTypeCode.Object;

        public virtual bool IsConstableType() => FullName.IsConstableType(FullName);

        public virtual void ResolveType(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            context.TypesToBuild.Add(this);
            TypeAttributes = typeDef.Attributes;

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

        public virtual void ResolveNestedTypes(BuilderContext context, TypeDefinition typeDef)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            foreach (var handle in typeDef.GetNestedTypes())
            {
                var nestedDef = context.MetadataReader.GetTypeDefinition(handle);
                var nestedType = context.CreateBuilderType(nestedDef);
                if (!context.TypesToBuild.TryGetValue(nestedType, out var existing))
                {
                    existing = nestedType;
                    context.AddDependencies(existing);
                }
                NestedTypes.Add(existing);
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
                var field = context.CreateBuilderField(context.MetadataReader.GetString(fieldDef.Name), fieldDef.DecodeSignature(context.SignatureTypeProvider, null));
                field.Attributes = fieldDef.Attributes;
                field.DefaultValueAsBytes = context.MetadataReader.GetConstantBytes(fieldDef.GetDefaultValue());

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

            if (GeneratedName != null)
                return GeneratedName;

            var un = context.Configuration.GetGeneration();
            if (WellKnownTypes.All.TryGetValue(FullName, out var type))
            {
                if (type.GeneratedName != null)
                    return type.GeneratedName;

                if (context.ImplicitNamespaces.Contains(type.FullName.Namespace))
                    return FullName.Name;

                if (type.FullName.Namespace == context.Namespace)
                    return type.FullName.Name;

                if (un != null)
                    return type.FullName.Name;

                return type.FullName.ToString();
            }

            if (context.ImplicitNamespaces.Contains(FullName.Namespace))
                return FullName.Name;

            if (FullName.Namespace == context.Namespace)
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

            // base type handling (only for functions and constants)
            if (GetType() == typeof(BuilderType))
            {
                var un = context.Configuration.GetGeneration();
                if (un != null)
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
            }

            using var writer = new StringWriter();
            context.Writer = new IndentedTextWriter(writer);
            try
            {
                GenerateCode(context);
            }
            finally
            {
                context.Writer.Dispose();
                context.Writer = null;
            }

            var ns = context.MapGeneratedFullName(FullName).Namespace.Replace('.', Path.DirectorySeparatorChar);
            var text = writer.ToString();
            var fileName = FileName + ".cs";
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
            ArgumentNullException.ThrowIfNull(context.Writer);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.Generation);

            string ns;
            if (GetType() == typeof(BuilderType))
            {
                // it's not structure, interface or enum
                // so it's not unified functions or constants
                // so, don't map namespace
                ns = FullName.Namespace;
            }
            else
            {
                ns = context.MapGeneratedFullName(FullName).Namespace;
            }

            context.Writer.WriteLine($"namespace {ns};");
            context.Writer.WriteLine();
            context.Namespace = ns;

            if (Documentation != null)
            {
                context.Writer.WriteLine("// " + Documentation);
            }
            GenerateTypeCode(context);
            context.Namespace = null;
        }

        protected virtual void GenerateTypeCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            if (Methods.Count == 0 && Fields.Count == 0)
                return;

            var un = context.Configuration.GetGeneration();

            context.Writer.Write($"public partial class {FullName.Name}");
            context.Writer.WriteLine();
            context.Writer.WithParens(() =>
            {
                if (un == null || un.ConstantsFileName == null)
                {
                    for (var i = 0; i < Fields.Count; i++)
                    {
                        var field = Fields[i];
                        if (field.Documentation != null)
                        {
                            context.Writer.WriteLine("// " + field.Documentation);
                        }

                        var mapped = context.MapType(field.Type);
                        if (mapped.UnmanagedType.HasValue)
                        {
                            context.Writer.WriteLine($"[MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                        }

                        var constText = field.Attributes.HasFlag(FieldAttributes.Literal) && field.Type.IsConstableType() ? "const" : "static readonly";
                        context.Writer.WriteLine($"public {constText} {mapped.GetGeneratedName(context)} {field} = {field.Type.GetValueAsString(context, field.DefaultValue)};");

                        if (i != Fields.Count - 1 || Methods.Count > 0)
                        {
                            context.Writer.WriteLine();
                        }
                    }
                }

                if (un == null || un.FunctionsFileName == null)
                {
                    for (var i = 0; i < Methods.Count; i++)
                    {
                        var method = Methods[i];

                        if (method.Documentation != null)
                        {
                            context.Writer.WriteLine("// " + method.Documentation);
                        }

                        if (method.ImportModuleName != null)
                        {
                            var module = method.ImportModuleName;
                            const string dll = ".dll";
                            if (module.EndsWith(dll, StringComparison.InvariantCultureIgnoreCase))
                            {
                                module = module[..^dll.Length];
                            }

                            context.Writer.Write($"[LibraryImport(\"{module}\"");
                            if (method.IsUnicode)
                            {
                                context.Writer.Write(", StringMarshalling = StringMarshalling.Utf16");
                            }
                            context.Writer.WriteLine(")]");
                        }

                        if (method.SupportedOSPlatform != null)
                        {
                            context.Writer.WriteLine($"[SupportedOSPlatform(\"{method.SupportedOSPlatform}\")]");
                        }

                        context.Writer.WriteLine("[PreserveSig]");
                        string typeName;
                        if (method.ReturnType != null)
                        {
                            var mapped = context.MapType(method.ReturnType);

                            // don't map here? should be done already? causes trouble with HRESULT
                            //if (mapped.UnmanagedType.HasValue)
                            //{
                            //    context.Writer.WriteLine($"[return: MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                            //}

                            typeName = mapped.GetGeneratedName(context);
                        }
                        else
                        {
                            typeName = "void";
                        }

                        context.Writer.Write($"public static partial {typeName} {method}(");
                        for (var j = 0; j < method.Parameters.Count; j++)
                        {
                            var parameter = method.Parameters[j];
                            parameter.GeneratedCode(context);
                            if (j != method.Parameters.Count - 1)
                            {
                                context.Writer.Write(", ");
                            }
                        }
                        context.Writer.WriteLine(");");

                        if (i != Methods.Count - 1)
                        {
                            context.Writer.WriteLine();
                        }
                    }
                }
            });
        }

        public virtual string GetValueAsString(BuilderContext context, object? value)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (value == null)
                return "null";

            if (value is Guid guid)
                return $"new(\"{guid}\")";

            if (value is bool b)
                return b ? "true" : "false";

            if (value is string s)
                return $"@\"{s.Replace("\"", "\"\"")}\"";

            return string.Format(CultureInfo.InvariantCulture, "{0}", value);
        }

        public virtual BuilderType CloneType(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (this is InterfaceType)
                return context.CreateInterfaceType(FullName);

            if (this is InlineArrayType at)
                return context.CreateInlineArrayType(at.ElementType, at.Size);

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
            copy.IsStructure = IsStructure;
            copy.Indirections = Indirections;
            copy.ArrayShape = ArrayShape;
            copy.Methods.AddRange(Methods);
            copy.Fields.AddRange(Fields);
            copy.Interfaces.AddRange(Interfaces);
            copy.NestedTypes.AddRange(NestedTypes);
            copy.Documentation = Documentation;
            copy.SupportedOSPlatform = SupportedOSPlatform;
            copy.Guid = Guid;
            copy.GeneratedName = GeneratedName;
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
