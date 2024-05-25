#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMDRIVER : IEquatable<HACMDRIVER>
{
    public static readonly HACMDRIVER Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HACMDRIVER value && Equals(value);
    public readonly bool Equals(HACMDRIVER other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMDRIVER left, HACMDRIVER right) => left.Equals(right);
    public static bool operator !=(HACMDRIVER left, HACMDRIVER right) => !left.Equals(right);
}
