#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HGLRC : IEquatable<HGLRC>
{
    public static readonly HGLRC Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HGLRC value && Equals(value);
    public readonly bool Equals(HGLRC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HGLRC left, HGLRC right) => left.Equals(right);
    public static bool operator !=(HGLRC left, HGLRC right) => !left.Equals(right);
}
