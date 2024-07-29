#nullable enable
namespace DirectN;

public partial struct HIC : IEquatable<HIC>
{
    public static readonly HIC Null = new();
    
    public nint Value;
    
    public HIC(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HIC value && Equals(value);
    public readonly bool Equals(HIC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HIC left, HIC right) => left.Equals(right);
    public static bool operator !=(HIC left, HIC right) => !left.Equals(right);
    public static implicit operator nint(HIC value) => value.Value;
    public static implicit operator HIC(nint value) => new(value);
}
