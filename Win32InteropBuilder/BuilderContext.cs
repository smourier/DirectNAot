using System;
using System.Collections.Generic;
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
        }

        public BuilderConfiguration Configuration { get; }
        public virtual MetadataReader? MetadataReader { get; set; }
        public virtual ISet<BuilderType> TypesToBuild { get; } = new HashSet<BuilderType>();
        public virtual IDictionary<FullName, BuilderType> AllTypes { get; } = new Dictionary<FullName, BuilderType>();
        public virtual IDictionary<FullName, TypeDefinition> TypeDefinitions { get; } = new Dictionary<FullName, TypeDefinition>();
    }
}
