#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HTHEME : IEquatable<HTHEME>
{
    public static readonly HTHEME Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HTHEME value && Equals(value);
    public readonly bool Equals(HTHEME other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HTHEME left, HTHEME right) => left.Equals(right);
    public static bool operator !=(HTHEME left, HTHEME right) => !left.Equals(right);
}
