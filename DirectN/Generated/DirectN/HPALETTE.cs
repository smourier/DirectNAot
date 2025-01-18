#nullable enable
namespace DirectN;

public partial struct HPALETTE : IEquatable<HPALETTE>
{
    public static readonly HPALETTE Null = new();
    
    public nint Value;
    
    public HPALETTE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HPALETTE value && Equals(value);
    public readonly bool Equals(HPALETTE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HPALETTE left, HPALETTE right) => left.Equals(right);
    public static bool operator !=(HPALETTE left, HPALETTE right) => !left.Equals(right);
    public static implicit operator nint(HPALETTE value) => value.Value;
    public static implicit operator HPALETTE(nint value) => new(value);
}
