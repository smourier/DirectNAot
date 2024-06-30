#nullable enable
namespace DirectN;

public partial struct WPARAM : IEquatable<WPARAM>
{
    public static readonly WPARAM Null = new();
    
    public nuint Value;
    
    public override readonly bool Equals(object? obj) => obj is WPARAM value && Equals(value);
    public readonly bool Equals(WPARAM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(WPARAM left, WPARAM right) => left.Equals(right);
    public static bool operator !=(WPARAM left, WPARAM right) => !left.Equals(right);
}
