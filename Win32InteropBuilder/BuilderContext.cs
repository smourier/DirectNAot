﻿using System;
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
        }

        public BuilderConfiguration Configuration { get; }
        public virtual SignatureTypeProvider SignatureTypeProvider { get; }
        public virtual MetadataReader? MetadataReader { get; set; }
        public virtual IndentedTextWriter? Writer { get; set; }
        public virtual string? Namespace { get; set; }
        public virtual ISet<BuilderType> TypesToBuild { get; } = new HashSet<BuilderType>();
        public virtual IDictionary<FullName, BuilderType> AllTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual IDictionary<FullName, TypeDefinition> TypeDefinitions { get; } = new Dictionary<FullName, TypeDefinition>();

        public virtual BuilderType CreateBuilderType(FullName fullName) => new(fullName);
        public virtual InterfaceType CreateInterfaceType(FullName fullName) => new(fullName);
        public virtual StructureType CreateStructureType(FullName fullName) => new(fullName);
        public virtual EnumType CreateEnumType(FullName fullName) => new(fullName);
        public virtual BuilderMethod CreateBuilderMethod(string name) => new(name);
        public virtual BuilderParameter CreateBuilderParameter(string name, int sequenceNumber) => new(name, sequenceNumber);
        public virtual BuilderField CreateBuilderField(string name, BuilderType type) => new(name, type);

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
    }
}
