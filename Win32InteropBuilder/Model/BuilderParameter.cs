using System;

namespace Win32InteropBuilder.Model
{
    public class BuilderParameter
    {
        public BuilderParameter(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }

        public string Name { get; }

        public override string ToString() => Name;
    }
}
