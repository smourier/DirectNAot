#nullable enable
namespace DirectN;

public partial struct HBRUSH : IEquatable<HBRUSH>
{
    public static readonly HBRUSH Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HBRUSH value && Equals(value);
    public readonly bool Equals(HBRUSH other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HBRUSH left, HBRUSH right) => left.Equals(right);
    public static bool operator !=(HBRUSH left, HBRUSH right) => !left.Equals(right);
}
