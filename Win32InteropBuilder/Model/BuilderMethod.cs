using System;
using System.Collections.Generic;

namespace Win32InteropBuilder.Model
{
    public class BuilderMethod
    {
        private readonly List<BuilderParameter> _parameters = [];

        public BuilderMethod(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }

        public string Name { get; }
        public IList<BuilderParameter> Parameters => _parameters;

        public override string ToString() => Name;
    }
}
