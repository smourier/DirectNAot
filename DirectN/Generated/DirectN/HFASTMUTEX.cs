#nullable enable
namespace DirectN;

public partial struct HFASTMUTEX : IEquatable<HFASTMUTEX>
{
    public static readonly HFASTMUTEX Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HFASTMUTEX value && Equals(value);
    public readonly bool Equals(HFASTMUTEX other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HFASTMUTEX left, HFASTMUTEX right) => left.Equals(right);
    public static bool operator !=(HFASTMUTEX left, HFASTMUTEX right) => !left.Equals(right);
}
