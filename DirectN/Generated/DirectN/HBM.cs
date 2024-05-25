#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HBM : IEquatable<HBM>
{
    public static readonly HBM Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HBM value && Equals(value);
    public readonly bool Equals(HBM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HBM left, HBM right) => left.Equals(right);
    public static bool operator !=(HBM left, HBM right) => !left.Equals(right);
}
