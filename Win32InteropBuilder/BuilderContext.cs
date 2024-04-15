using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder
{
    public class BuilderContext
    {
        public BuilderContext(BuilderConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            Configuration = configuration;
            SignatureTypeProvider = new SignatureTypeProvider(this);
            ImplicitNamespaces.Add("System");
            ImplicitNamespaces.Add(BuilderType.GeneratedInteropNamespace);
        }

        public BuilderConfiguration Configuration { get; }
        public virtual SignatureTypeProvider SignatureTypeProvider { get; }
        public virtual MetadataReader? MetadataReader { get; set; }
        public virtual IndentedTextWriter? Writer { get; set; }
        public virtual string? Namespace { get; set; }
        public virtual ISet<BuilderType> TypesToBuild { get; } = new HashSet<BuilderType>();
        public virtual IDictionary<FullName, BuilderType> AllTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual IDictionary<FullName, TypeDefinition> TypeDefinitions { get; } = new Dictionary<FullName, TypeDefinition>();
        public virtual IDictionary<FullName, BuilderType> MappedTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual ISet<string> ImplicitNamespaces { get; } = new HashSet<string>();

        public virtual BuilderType CreateBuilderType(FullName fullName) => new(fullName);
        public virtual InterfaceType CreateInterfaceType(FullName fullName) => new(fullName);
        public virtual StructureType CreateStructureType(FullName fullName) => new(fullName);
        public virtual EnumType CreateEnumType(FullName fullName) => new(fullName);
        public virtual BuilderMethod CreateBuilderMethod(string name) => new(name);
        public virtual BuilderParameter CreateBuilderParameter(string name, int sequenceNumber) => new(name, sequenceNumber);
        public virtual BuilderField CreateBuilderField(string name, BuilderType type) => new(name, type);
        public virtual BuilderType CreateInlineArrayType(BuilderType elementType, int size) => new InlineArrayType(elementType, size);

        public virtual BuilderType CreateBuilderType(TypeDefinition typeDef)
        {
            if (MetadataReader == null)
                throw new InvalidOperationException();

            if (typeDef.Attributes.HasFlag(TypeAttributes.Interface))
                return CreateInterfaceType(MetadataReader.GetFullName(typeDef));

            var isStructure = MetadataReader.IsStructure(typeDef);
            if (isStructure)
                return CreateStructureType(MetadataReader.GetFullName(typeDef));

            var isEnum = MetadataReader.IsEnum(typeDef);
            if (isEnum)
                return CreateEnumType(MetadataReader.GetFullName(typeDef));

            return CreateBuilderType(MetadataReader.GetFullName(typeDef));
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

            var unified = Configuration.Generation.UnifiedNamespace.Nullify();
            if (unified != null)
                return new FullName(unified, FullName.HRESULT.Name);

            return fullName;
        }
    }
}
