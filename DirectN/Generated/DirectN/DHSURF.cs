#nullable enable
namespace DirectN;

public partial struct DHSURF : IEquatable<DHSURF>
{
    public static readonly DHSURF Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is DHSURF value && Equals(value);
    public readonly bool Equals(DHSURF other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(DHSURF left, DHSURF right) => left.Equals(right);
    public static bool operator !=(DHSURF left, DHSURF right) => !left.Equals(right);
}
