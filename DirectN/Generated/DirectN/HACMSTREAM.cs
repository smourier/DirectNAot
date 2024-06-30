#nullable enable
namespace DirectN;

public partial struct HACMSTREAM : IEquatable<HACMSTREAM>
{
    public static readonly HACMSTREAM Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HACMSTREAM value && Equals(value);
    public readonly bool Equals(HACMSTREAM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMSTREAM left, HACMSTREAM right) => left.Equals(right);
    public static bool operator !=(HACMSTREAM left, HACMSTREAM right) => !left.Equals(right);
}
