#nullable enable
namespace DirectN;

public partial struct LPARAM : IEquatable<LPARAM>
{
    public static readonly LPARAM Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is LPARAM value && Equals(value);
    public readonly bool Equals(LPARAM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(LPARAM left, LPARAM right) => left.Equals(right);
    public static bool operator !=(LPARAM left, LPARAM right) => !left.Equals(right);
}
