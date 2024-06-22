#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HSURF : IEquatable<HSURF>
{
    public static readonly HSURF Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HSURF value && Equals(value);
    public readonly bool Equals(HSURF other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HSURF left, HSURF right) => left.Equals(right);
    public static bool operator !=(HSURF left, HSURF right) => !left.Equals(right);
}
