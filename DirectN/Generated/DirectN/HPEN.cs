#nullable enable
namespace DirectN;

public partial struct HPEN : IEquatable<HPEN>, IValueGet<nint>
{
    public static readonly HPEN Null = new();
    
    public nint Value;
    
    public HPEN(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HPEN value && Equals(value);
    public readonly bool Equals(HPEN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HPEN left, HPEN right) => left.Equals(right);
    public static bool operator !=(HPEN left, HPEN right) => !left.Equals(right);
    public static implicit operator nint(HPEN value) => value.Value;
    public static implicit operator HPEN(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
