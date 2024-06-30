#nullable enable
namespace DirectN;

public partial struct HPALETTE : IEquatable<HPALETTE>
{
    public static readonly HPALETTE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HPALETTE value && Equals(value);
    public readonly bool Equals(HPALETTE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HPALETTE left, HPALETTE right) => left.Equals(right);
    public static bool operator !=(HPALETTE left, HPALETTE right) => !left.Equals(right);
}
