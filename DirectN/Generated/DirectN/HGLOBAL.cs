#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HGLOBAL : IEquatable<HGLOBAL>
{
    public static readonly HGLOBAL Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HGLOBAL value && Equals(value);
    public readonly bool Equals(HGLOBAL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HGLOBAL left, HGLOBAL right) => left.Equals(right);
    public static bool operator !=(HGLOBAL left, HGLOBAL right) => !left.Equals(right);
}
