using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using Win32InteropBuilder.Model;

namespace Win32InteropBuilder
{
    public class BuilderContext
    {
        public BuilderContext(BuilderConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            Configuration = configuration;
            SignatureTypeProvider = new SignatureTypeProvider(this);
            CustomAttributeTypeProvider = new CustomAttributeTypeProvider(this);
            ImplicitNamespaces.Add("System");
            ImplicitNamespaces.Add(BuilderType.GeneratedInteropNamespace);
        }

        public BuilderConfiguration Configuration { get; }
        public virtual SignatureTypeProvider SignatureTypeProvider { get; }
        public virtual CustomAttributeTypeProvider CustomAttributeTypeProvider { get; }
        public virtual MetadataReader? MetadataReader { get; set; }
        public virtual IndentedTextWriter? Writer { get; set; }
        public virtual string? Namespace { get; set; }
        public virtual HashSet<BuilderType> TypesToBuild { get; } = [];
        public virtual IDictionary<FullName, BuilderType> AllTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual IDictionary<FullName, TypeDefinition> TypeDefinitions { get; } = new Dictionary<FullName, TypeDefinition>();
        public virtual IDictionary<FullName, BuilderType> MappedTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual ISet<string> ImplicitNamespaces { get; } = new HashSet<string>();
        public virtual ISet<string> ExistingFiles { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public virtual ISet<BuilderType> FunctionsTypes { get; } = new HashSet<BuilderType>();
        public virtual ISet<BuilderType> ConstantsTypes { get; } = new HashSet<BuilderType>();

        public virtual BuilderType CreateBuilderType(FullName fullName) => new(fullName);
        public virtual InterfaceType CreateInterfaceType(FullName fullName) => new(fullName);
        public virtual StructureType CreateStructureType(FullName fullName) => new(fullName);
        public virtual EnumType CreateEnumType(FullName fullName) => new(fullName);
        public virtual BuilderMethod CreateBuilderMethod(string name) => new(name);
        public virtual BuilderParameter CreateBuilderParameter(string name, int sequenceNumber) => new(name, sequenceNumber);
        public virtual BuilderField CreateBuilderField(string name, BuilderType type) => new(name, type);
        public virtual BuilderType CreateInlineArrayType(BuilderType elementType, int size) => new InlineArrayType(elementType, size);

        protected virtual FullName GetFullName(TypeDefinition typeDef)
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
                    var nestedFn = new FullName(declaringTypeFn.Namespace, declaringTypeFn.Name + "+" + fn.Name);
                    return nestedFn;
                }
            }
            return fn;
        }

        public virtual BuilderType CreateBuilderType(TypeDefinition typeDef)
        {
            if (MetadataReader == null)
                throw new InvalidOperationException();

            if (typeDef.Attributes.HasFlag(TypeAttributes.Interface))
                return CreateInterfaceType(GetFullName(typeDef));

            var isStructure = MetadataReader.IsStructure(typeDef);
            if (isStructure)
                return CreateStructureType(GetFullName(typeDef));

            var isEnum = MetadataReader.IsEnum(typeDef);
            if (isEnum)
                return CreateEnumType(GetFullName(typeDef));

            return CreateBuilderType(GetFullName(typeDef));
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
    }
}
