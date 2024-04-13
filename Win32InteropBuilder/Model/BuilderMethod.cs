using System;
using System.Collections.Generic;

namespace Win32InteropBuilder.Model
{
    public class BuilderMethod : IDocumentable
    {
        private readonly List<BuilderParameter> _parameters = [];

        public BuilderMethod(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }

        public string Name { get; }
        public virtual BuilderType? ReturnType { get; set; }
        public virtual IList<BuilderParameter> Parameters => _parameters;
        public virtual string? Documentation { get; set; }

        internal void SortParameters() => _parameters.Sort();

        public override string ToString() => Name;
    }
}
