#nullable enable
namespace DirectN;

public partial struct GLUtesselator : IEquatable<GLUtesselator>
{
    public static readonly GLUtesselator Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is GLUtesselator value && Equals(value);
    public readonly bool Equals(GLUtesselator other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(GLUtesselator left, GLUtesselator right) => left.Equals(right);
    public static bool operator !=(GLUtesselator left, GLUtesselator right) => !left.Equals(right);
}
