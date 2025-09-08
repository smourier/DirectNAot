#nullable enable
namespace DirectN;

public partial struct VARIANT_BOOL : IEquatable<VARIANT_BOOL>, IValueGet<short>
{
    public static readonly VARIANT_BOOL Null = new();
    
    public short Value;
    
    public VARIANT_BOOL(short value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is VARIANT_BOOL value && Equals(value);
    public readonly bool Equals(VARIANT_BOOL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(VARIANT_BOOL left, VARIANT_BOOL right) => left.Equals(right);
    public static bool operator !=(VARIANT_BOOL left, VARIANT_BOOL right) => !left.Equals(right);
    public static implicit operator short(VARIANT_BOOL value) => value.Value;
    public static implicit operator VARIANT_BOOL(short value) => new(value);
    
    readonly short IValueGet<short>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
