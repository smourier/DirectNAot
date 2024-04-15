using System;

namespace Win32InteropBuilder.Model
{
    public class BuildMember : IDocumentable, ISupportable
    {
        public BuildMember(string name)
        {
            ArgumentNullException.ThrowIfNull(name);
            Name = name;
        }

        public virtual string? Documentation { get; set; }
        public virtual string? SupportedOSPlatform { get; set; }

        public string Name { get; }
        public override int GetHashCode() => Name.GetHashCode();
    }
}
