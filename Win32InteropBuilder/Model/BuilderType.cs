using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace Win32InteropBuilder.Model
{
    public class BuilderType : IEquatable<BuilderType>, IDocumentable
    {
        public static BuilderType Int32 { get; } = new(typeof(int)) { GeneratedName = "int" };
        public static BuilderType Int64 { get; } = new(typeof(long)) { GeneratedName = "long" };
        public static BuilderType UInt32 { get; } = new(typeof(uint)) { GeneratedName = "uint" };
        public static BuilderType UInt64 { get; } = new(typeof(ulong)) { GeneratedName = "ulong" };
        public static BuilderType Guid { get; } = new(typeof(Guid));
        public static BuilderType Void { get; } = new(typeof(void)) { GeneratedName = "void" };

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
        public virtual string FileName => FullName.Name;
        public virtual string? GeneratedName { get; set; }

        public string FinalGeneratedName
        {
            get
            {
                if (GeneratedName != null)
                    return GeneratedName;

                if (WellKnownTypes.TryGetValue(FullName, out var builderType))
                    return builderType.GeneratedName ?? builderType.FullName.Name;

                return FullName.Name;
            }
        }

        public virtual void GenerateCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
            writer.WriteLine($"namespace {FullName.Namespace};");
            writer.WriteLine();
            GenerateTypeCode(writer);
        }

        protected virtual void GenerateTypeCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
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
