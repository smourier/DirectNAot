using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder.Model
{
    public class BuilderType : IEquatable<BuilderType>, IDocumentable, ISupportable
    {
        public const string GeneratedInteropNamespace = "System.Runtime.InteropServices.InteropTypes";

        private readonly List<BuilderMethod> _methods = [];
        private readonly List<BuilderField> _fields = [];
        private readonly List<BuilderType> _interfaces = [];

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
        //public BuilderType? BaseType { get; set; }
        public virtual bool IsGenerated { get; set; } = true;
        public virtual bool IsStructure { get; set; }
        public virtual int Indirections { get; set; }
        public virtual ArrayShape? ArrayShape { get; set; }
        public virtual IList<BuilderMethod> Methods => _methods;
        public virtual IList<BuilderField> Fields => _fields;
        public virtual IList<BuilderType> Interfaces => _interfaces;
        public virtual string? Documentation { get; set; }
        public virtual string? SupportedOSPlatform { get; set; }
        public virtual Guid? Guid { get; set; }
        public virtual string FileName => FullName.Name;
        public virtual string? GeneratedName { get; set; }
        public virtual UnmanagedType? UnmanagedType { get; set; }

        public virtual string GetGeneratedName(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.MappedTypes.TryGetValue(FullName, out var mappedType))
                return mappedType.GetGeneratedName(context);

            if (GeneratedName != null)
                return GeneratedName;

            if (WellKnownTypes.All.TryGetValue(FullName, out var type))
            {
                if (type.GeneratedName != null)
                    return type.GeneratedName;

                if (context.ImplicitNamespaces.Contains(type.FullName.Namespace))
                    return FullName.Name;

                if (type.FullName.Namespace == context.Namespace)
                    return type.FullName.Name;

                return type.FullName.ToString();
            }

            if (context.ImplicitNamespaces.Contains(FullName.Namespace))
                return FullName.Name;

            if (FullName.Namespace == context.Namespace)
                return FullName.Name;

            return ToString();
        }

        public virtual void GenerateCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            ArgumentNullException.ThrowIfNull(context.Configuration);

            var ns = context.Configuration.UnifyNamespaces.Nullify() ?? FullName.Namespace;
            context.Writer.WriteLine($"namespace {ns};");
            context.Writer.WriteLine();
            context.Namespace = FullName.Namespace;

            if (Documentation != null)
            {
                context.Writer.WriteLine("// " + Documentation);
            }
            GenerateTypeCode(context);
            context.Namespace = null;
        }

        protected virtual void GenerateTypeCode(BuilderContext context)
        {
            throw new NotSupportedException();
        }

        public virtual BuilderType Clone(BuilderContext context)
        {
            if (this is InterfaceType)
                return context.CreateInterfaceType(FullName);

            if (this is StructureType)
                return context.CreateStructureType(FullName);

            return context.CreateBuilderType(FullName);
        }

        public override int GetHashCode() => FullName.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as BuilderType);
        public bool Equals(BuilderType? other) => other != null && other.FullName == FullName;
        public override string ToString() => FullName.ToString();
    }
}
