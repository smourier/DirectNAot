#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIDIIN : IEquatable<HMIDIIN>
{
    public static readonly HMIDIIN Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMIDIIN value && Equals(value);
    public readonly bool Equals(HMIDIIN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDIIN left, HMIDIIN right) => left.Equals(right);
    public static bool operator !=(HMIDIIN left, HMIDIIN right) => !left.Equals(right);
}
