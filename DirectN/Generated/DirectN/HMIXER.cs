#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIXER : IEquatable<HMIXER>
{
    public static readonly HMIXER Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMIXER value && Equals(value);
    public readonly bool Equals(HMIXER other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIXER left, HMIXER right) => left.Equals(right);
    public static bool operator !=(HMIXER left, HMIXER right) => !left.Equals(right);
}
