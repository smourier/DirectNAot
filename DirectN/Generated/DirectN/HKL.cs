#nullable enable
namespace DirectN;

public partial struct HKL : IEquatable<HKL>, IValueGet<nint>
{
    public static readonly HKL Null = new();
    
    public nint Value;
    
    public HKL(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HKL value && Equals(value);
    public readonly bool Equals(HKL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HKL left, HKL right) => left.Equals(right);
    public static bool operator !=(HKL left, HKL right) => !left.Equals(right);
    public static implicit operator nint(HKL value) => value.Value;
    public static implicit operator HKL(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
