#nullable enable
namespace DirectN;

public partial struct HMIDISTRM : IEquatable<HMIDISTRM>
{
    public static readonly HMIDISTRM Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMIDISTRM value && Equals(value);
    public readonly bool Equals(HMIDISTRM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDISTRM left, HMIDISTRM right) => left.Equals(right);
    public static bool operator !=(HMIDISTRM left, HMIDISTRM right) => !left.Equals(right);
}
