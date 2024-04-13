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
        public virtual int Indirections { get; set; }
        public virtual ArrayShape? ArrayShape { get; set; }
        public virtual IList<BuilderMethod> Methods => _methods;
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

        public virtual void GeneratedCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
            writer.WriteLine($"namespace {FullName.Namespace};");
            writer.WriteLine();
            writer.Write($"public partial interface {FullName.Name}");
            writer.WriteLine();
            writer.WithParens(() =>
            {
                for (var i = 0; i < Methods.Count; i++)
                {
                    var method = Methods[i];
                    writer.WriteLine("[PreserveSig]");
                    writer.Write(method.ReturnType?.FullName.Name ?? "void");
                    writer.Write(' ');
                    writer.Write(method);

                    writer.Write('(');
                    for (var j = 0; j < method.Parameters.Count; j++)
                    {
                        var parameter = method.Parameters[j];
                        parameter.GeneratedCode(writer);
                        if (j != method.Parameters.Count - 1)
                        {
                            writer.Write(", ");
                        }
                    }
                    writer.WriteLine(");");

                    if (i != Methods.Count - 1)
                    {
                        writer.WriteLine();
                    }
                }
            });
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
