#nullable enable
namespace DirectN;

public partial struct HIMC : IEquatable<HIMC>
{
    public static readonly HIMC Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HIMC value && Equals(value);
    public readonly bool Equals(HIMC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HIMC left, HIMC right) => left.Equals(right);
    public static bool operator !=(HIMC left, HIMC right) => !left.Equals(right);
}
