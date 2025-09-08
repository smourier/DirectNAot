#nullable enable
namespace DirectN;

public partial struct HIMC : IEquatable<HIMC>, IValueGet<nint>
{
    public static readonly HIMC Null = new();
    
    public nint Value;
    
    public HIMC(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HIMC value && Equals(value);
    public readonly bool Equals(HIMC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HIMC left, HIMC right) => left.Equals(right);
    public static bool operator !=(HIMC left, HIMC right) => !left.Equals(right);
    public static implicit operator nint(HIMC value) => value.Value;
    public static implicit operator HIMC(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
