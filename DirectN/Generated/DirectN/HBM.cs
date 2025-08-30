#nullable enable
namespace DirectN;

public partial struct HBM : IEquatable<HBM>, IValueGet<nint>
{
    public static readonly HBM Null = new();
    
    public nint Value;
    
    public HBM(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HBM value && Equals(value);
    public readonly bool Equals(HBM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HBM left, HBM right) => left.Equals(right);
    public static bool operator !=(HBM left, HBM right) => !left.Equals(right);
    public static implicit operator nint(HBM value) => value.Value;
    public static implicit operator HBM(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
