#nullable enable
namespace DirectN;

public partial struct HINSTANCE : IEquatable<HINSTANCE>
{
    public static readonly HINSTANCE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HINSTANCE value && Equals(value);
    public readonly bool Equals(HINSTANCE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HINSTANCE left, HINSTANCE right) => left.Equals(right);
    public static bool operator !=(HINSTANCE left, HINSTANCE right) => !left.Equals(right);
}
