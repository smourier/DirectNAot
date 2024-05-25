#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWAVE : IEquatable<HWAVE>
{
    public static readonly HWAVE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HWAVE value && Equals(value);
    public readonly bool Equals(HWAVE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWAVE left, HWAVE right) => left.Equals(right);
    public static bool operator !=(HWAVE left, HWAVE right) => !left.Equals(right);
}
