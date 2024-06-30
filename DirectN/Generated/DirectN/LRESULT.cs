#nullable enable
namespace DirectN;

public partial struct LRESULT : IEquatable<LRESULT>
{
    public static readonly LRESULT Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is LRESULT value && Equals(value);
    public readonly bool Equals(LRESULT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(LRESULT left, LRESULT right) => left.Equals(right);
    public static bool operator !=(LRESULT left, LRESULT right) => !left.Equals(right);
}
