using System;
using System.Collections.Generic;
using System.Reflection;

namespace Win32InteropBuilder.Model
{
    public class BuilderMethod : IDocumentable, ISupportable, IComparable, IComparable<BuilderMethod>
    {
        private readonly List<BuilderParameter> _parameters = [];

        public BuilderMethod(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }

        public string Name { get; }
        public virtual MethodAttributes Attributes { get; set; }
        public virtual MethodImplAttributes ImplAttributes { get; set; }
        public virtual bool IsAnsi { get; set; }
        public virtual bool IsUnicode { get; set; }
        public virtual BuilderType? ReturnType { get; set; }
        public virtual IList<BuilderParameter> Parameters => _parameters;
        public virtual string? Documentation { get; set; }
        public virtual string? SupportedOSPlatform { get; set; }
        public virtual MethodImportAttributes ImportAttributes { get; set; }
        public virtual string? ImportEntryPoint { get; set; }
        public virtual string? ImportModuleName { get; set; }

        internal void SortParameters() => _parameters.Sort();

        int IComparable.CompareTo(object? obj) => CompareTo(obj as BuilderMethod);
        public int CompareTo(BuilderMethod? other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return Name.CompareTo(other.Name);
        }

        public override string ToString() => Name;
    }
}
