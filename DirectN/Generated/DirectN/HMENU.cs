#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMENU : IEquatable<HMENU>
{
    public static readonly HMENU Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMENU value && Equals(value);
    public readonly bool Equals(HMENU other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMENU left, HMENU right) => left.Equals(right);
    public static bool operator !=(HMENU left, HMENU right) => !left.Equals(right);
}
