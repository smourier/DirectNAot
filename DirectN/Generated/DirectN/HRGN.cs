#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HRGN : IEquatable<HRGN>
{
    public static readonly HRGN Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HRGN value && Equals(value);
    public readonly bool Equals(HRGN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HRGN left, HRGN right) => left.Equals(right);
    public static bool operator !=(HRGN left, HRGN right) => !left.Equals(right);
}
