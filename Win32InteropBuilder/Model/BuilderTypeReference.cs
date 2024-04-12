using System;

namespace Win32InteropBuilder.Model
{
    public class BuilderTypeReference : IEquatable<BuilderTypeReference>
    {
        public BuilderTypeReference(FullName fullName)
        {
            ArgumentNullException.ThrowIfNull(fullName);
            FullName = fullName;
        }

        public FullName FullName { get; }

        public override string ToString() => FullName.ToString();
        public override int GetHashCode() => FullName.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as BuilderTypeReference);
        public bool Equals(BuilderTypeReference? other) => other != null && other.FullName == FullName;
    }
}
