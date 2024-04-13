using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class BuilderType : IEquatable<BuilderType>, IDocumentable, ISupportable
    {
        public static BuilderType Systemboolean { get; } = new(typeof(bool)) { GeneratedName = "bool" };
        public static BuilderType SystemByte { get; } = new(typeof(byte)) { GeneratedName = "byte" };
        public static BuilderType SystemChar { get; } = new(typeof(char)) { GeneratedName = "char" };
        public static BuilderType SystemDouble { get; } = new(typeof(double)) { GeneratedName = "double" };
        public static BuilderType SystemGuid { get; } = new(typeof(Guid));
        public static BuilderType SystemInt16 { get; } = new(typeof(short)) { GeneratedName = "short" };
        public static BuilderType SystemInt32 { get; } = new(typeof(int)) { GeneratedName = "int" };
        public static BuilderType SystemInt64 { get; } = new(typeof(long)) { GeneratedName = "long" };
        public static BuilderType SystemIntPtr { get; } = new(typeof(nint)) { GeneratedName = "nint" };
        public static BuilderType SystemSByte { get; } = new(typeof(sbyte)) { GeneratedName = "sbyte" };
        public static BuilderType SystemSingle { get; } = new(typeof(float)) { GeneratedName = "float" };
        public static BuilderType SystemString { get; } = new(typeof(string)) { GeneratedName = "string" };
        public static BuilderType SystemUInt16 { get; } = new(typeof(ushort)) { GeneratedName = "ushort" };
        public static BuilderType SystemUInt32 { get; } = new(typeof(uint)) { GeneratedName = "uint" };
        public static BuilderType SystemUInt64 { get; } = new(typeof(ulong)) { GeneratedName = "ulong" };
        public static BuilderType SystemUIntPtr { get; } = new(typeof(nuint)) { GeneratedName = "nuint" };
        public static BuilderType SystemVoid { get; } = new(typeof(void)) { GeneratedName = "void" };

        // *warning* this must come *after* definitions of static BuilderType above
        private static readonly Lazy<IDictionary<FullName, BuilderType>> _wellKnownTypes = new(LoadWellKnownTypes);

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

        public virtual string GetGeneratedName(string? currentNamespace)
        {
            if (GeneratedName != null)
                return GeneratedName;

            if (WellKnownTypes.TryGetValue(FullName, out var type))
            {
                if (type.GeneratedName != null)
                    return type.GeneratedName;

                if (type.FullName.Namespace == currentNamespace)
                    return type.FullName.Name;

                return type.FullName.ToString();
            }

            if (FullName.Namespace == currentNamespace)
                return FullName.Name;

            return ToString();
        }

        public virtual void GenerateCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            context.Writer.WriteLine($"namespace {FullName.Namespace};");
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

        public static IDictionary<FullName, BuilderType> WellKnownTypes => _wellKnownTypes.Value;
        private static IDictionary<FullName, BuilderType> LoadWellKnownTypes
        {
            get
            {
                var dic = new ConcurrentDictionary<FullName, BuilderType>();
                foreach (var prop in typeof(BuilderType).GetProperties(BindingFlags.Static | BindingFlags.Public).Where(p => p.PropertyType == typeof(BuilderType)))
                {
                    var type = (BuilderType)prop.GetValue(null)!;
                    dic[type.FullName] = type;
                }
                return dic;
            }
        }
    }
}
