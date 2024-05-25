#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GLUnurbs : IEquatable<GLUnurbs>
{
    public static readonly GLUnurbs Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is GLUnurbs value && Equals(value);
    public readonly bool Equals(GLUnurbs other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(GLUnurbs left, GLUnurbs right) => left.Equals(right);
    public static bool operator !=(GLUnurbs left, GLUnurbs right) => !left.Equals(right);
}
