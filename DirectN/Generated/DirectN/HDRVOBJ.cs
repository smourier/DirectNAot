#nullable enable
namespace DirectN;

public partial struct HDRVOBJ : IEquatable<HDRVOBJ>
{
    public static readonly HDRVOBJ Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HDRVOBJ value && Equals(value);
    public readonly bool Equals(HDRVOBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDRVOBJ left, HDRVOBJ right) => left.Equals(right);
    public static bool operator !=(HDRVOBJ left, HDRVOBJ right) => !left.Equals(right);
}
