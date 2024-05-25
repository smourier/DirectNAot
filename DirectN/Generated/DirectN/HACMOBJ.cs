#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMOBJ : IEquatable<HACMOBJ>
{
    public static readonly HACMOBJ Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HACMOBJ value && Equals(value);
    public readonly bool Equals(HACMOBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMOBJ left, HACMOBJ right) => left.Equals(right);
    public static bool operator !=(HACMOBJ left, HACMOBJ right) => !left.Equals(right);
}
