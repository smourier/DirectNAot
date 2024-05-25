#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACCEL : IEquatable<HACCEL>
{
    public static readonly HACCEL Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HACCEL value && Equals(value);
    public readonly bool Equals(HACCEL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACCEL left, HACCEL right) => left.Equals(right);
    public static bool operator !=(HACCEL left, HACCEL right) => !left.Equals(right);
}
