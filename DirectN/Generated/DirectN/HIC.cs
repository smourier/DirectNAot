#nullable enable
namespace DirectN;

public partial struct HIC : IEquatable<HIC>
{
    public static readonly HIC Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HIC value && Equals(value);
    public readonly bool Equals(HIC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HIC left, HIC right) => left.Equals(right);
    public static bool operator !=(HIC left, HIC right) => !left.Equals(right);
}
