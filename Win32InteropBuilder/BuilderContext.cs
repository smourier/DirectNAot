using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder
{
    public class BuilderContext
    {
        public BuilderContext(BuilderConfiguration configuration, ILanguage language)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(language);
            Configuration = configuration;
            Language = language;
            SignatureTypeProvider = new SignatureTypeProvider(this);
            CustomAttributeTypeProvider = new CustomAttributeTypeProvider(this);
            ImplicitNamespaces.Add("System");
            ImplicitNamespaces.Add(BuilderType.GeneratedInteropNamespace);
        }

        public BuilderConfiguration Configuration { get; }
        public ILanguage Language { get; }
        public virtual ILogger? Logger { get; set; }
        public virtual SignatureTypeProvider SignatureTypeProvider { get; }
        public virtual CustomAttributeTypeProvider CustomAttributeTypeProvider { get; }
        public virtual MetadataReader? MetadataReader { get; set; }
        public virtual HashSet<BuilderType> TypesToBuild { get; } = [];
        public virtual IDictionary<FullName, BuilderType> AllTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual IDictionary<FullName, TypeDefinition> TypeDefinitions { get; } = new Dictionary<FullName, TypeDefinition>();
        public virtual IDictionary<FullName, BuilderType> MappedTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual ISet<string> ImplicitNamespaces { get; } = new HashSet<string>();
        public virtual ISet<string> ExistingFiles { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public virtual ISet<BuilderType> FunctionsTypes { get; } = new HashSet<BuilderType>();
        public virtual ISet<BuilderType> ConstantsTypes { get; } = new HashSet<BuilderType>();

        // changing properties
        public virtual IndentedTextWriter? CurrentWriter { get; set; }
        public virtual string? CurrentNamespace { get; set; }
        public virtual Stack<BuilderType> CurrentTypes { get; } = [];

        public virtual BuilderType CreateBuilderType(FullName fullName) => new(fullName);
        public virtual InterfaceType CreateInterfaceType(FullName fullName) => new(fullName);
        public virtual StructureType CreateStructureType(FullName fullName) => new(fullName);
        public virtual EnumType CreateEnumType(FullName fullName) => new(fullName);
        public virtual DelegateType CreateDelegateType(FullName fullName) => new(fullName);
        public virtual BuilderMethod CreateBuilderMethod(string name) => new(name);
        public virtual BuilderParameter CreateBuilderParameter(string name, int sequenceNumber) => new(name, sequenceNumber);
        public virtual BuilderField CreateBuilderField(string name, BuilderType type) => new(name, type);
        public virtual BuilderType CreateInlineArrayType(BuilderType elementType, int size) => new InlineArrayType(elementType, size);

        public virtual FullName GetFullName(TypeDefinition typeDef)
        {
            if (MetadataReader == null)
                throw new InvalidOperationException();

            var fn = MetadataReader.GetFullName(typeDef);
            if (fn.Namespace == string.Empty)
            {
                var declaringTypeHandle = typeDef.GetDeclaringType();
                if (!declaringTypeHandle.IsNil)
                {
                    // nested classes
                    var declaringTypeDef = MetadataReader.GetTypeDefinition(declaringTypeHandle);
                    var declaringTypeFn = GetFullName(declaringTypeDef);
                    var nestedFn = new FullName(declaringTypeFn.Namespace, declaringTypeFn.Name + FullName.NestedTypesSeparator + fn.Name);
                    return nestedFn;
                }
            }
            return fn;
        }

        public virtual BuilderType? CreateBuilderType(TypeDefinition typeDef)
        {
            if (Configuration == null)
                throw new InvalidOperationException();

            // skip non corresponding architectures
            var arch = this.GetSupportedArchitecture(typeDef.GetCustomAttributes());
            if (arch != null && (arch & Configuration.Architecture) != Configuration.Architecture)
                return null;

            var type = CreateBuilderTypeCore(typeDef);
            return type;
        }

        protected virtual BuilderType CreateBuilderTypeCore(TypeDefinition typeDef)
        {
            if (MetadataReader == null)
                throw new InvalidOperationException();

            var fn = GetFullName(typeDef);
            if (typeDef.Attributes.HasFlag(TypeAttributes.Interface))
                return CreateInterfaceType(fn);

            var isStructure = MetadataReader.IsStructure(typeDef);
            if (isStructure)
                return CreateStructureType(fn);

            var isEnum = MetadataReader.IsEnum(typeDef);
            if (isEnum)
                return CreateEnumType(fn);

            var isDelegate = MetadataReader.IsDelegate(typeDef);
            if (isDelegate)
                return CreateDelegateType(fn);

            return CreateBuilderType(fn);
        }

        public virtual void AddDependencies(BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(type);
            if (MetadataReader == null)
                throw new InvalidOperationException();

            if (!TypeDefinitions.TryGetValue(type.FullName, out var typeDef))
                return;

            if (TypesToBuild.Contains(type))
                return;

            type.ResolveType(this, typeDef);
        }

        public virtual BuilderType MapType(BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(type);
            if (MappedTypes.TryGetValue(type.FullName, out var mapped))
                return mapped;

            return type;
        }

        public virtual FullName MapGeneratedFullName(FullName fullName)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            ArgumentNullException.ThrowIfNull(Configuration);
            ArgumentNullException.ThrowIfNull(Configuration.Generation);

            var un = Configuration.GetGeneration();
            if (un != null)
                return new FullName(un.Namespace!, FullName.HRESULT.Name);

            return fullName;
        }

        public void LogInfo(object? message = null, [CallerMemberName] string? methodName = null) => Log(TraceLevel.Info, message, methodName);
        public void LogWarning(object? message = null, [CallerMemberName] string? methodName = null) => Log(TraceLevel.Warning, message, methodName);
        public void LogError(object? message = null, [CallerMemberName] string? methodName = null) => Log(TraceLevel.Error, message, methodName);
        public void LogVerbose(object? message = null, [CallerMemberName] string? methodName = null) => Log(TraceLevel.Verbose, message, methodName);
        public virtual void Log(TraceLevel level, object? message = null, [CallerMemberName] string? methodName = null) => Logger?.Log(level, message, methodName);
    }
}
