#nullable enable
namespace DirectN;

public partial struct GLUquadric : IEquatable<GLUquadric>
{
    public static readonly GLUquadric Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is GLUquadric value && Equals(value);
    public readonly bool Equals(GLUquadric other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(GLUquadric left, GLUquadric right) => left.Equals(right);
    public static bool operator !=(GLUquadric left, GLUquadric right) => !left.Equals(right);
}
