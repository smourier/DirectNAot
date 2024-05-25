#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct LPDDFXROP : IEquatable<LPDDFXROP>
{
    public static readonly LPDDFXROP Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is LPDDFXROP value && Equals(value);
    public readonly bool Equals(LPDDFXROP other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(LPDDFXROP left, LPDDFXROP right) => left.Equals(right);
    public static bool operator !=(LPDDFXROP left, LPDDFXROP right) => !left.Equals(right);
}
