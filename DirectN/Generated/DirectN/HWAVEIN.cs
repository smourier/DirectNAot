#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWAVEIN : IEquatable<HWAVEIN>
{
    public static readonly HWAVEIN Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HWAVEIN value && Equals(value);
    public readonly bool Equals(HWAVEIN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWAVEIN left, HWAVEIN right) => left.Equals(right);
    public static bool operator !=(HWAVEIN left, HWAVEIN right) => !left.Equals(right);
}
