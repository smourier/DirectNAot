#nullable enable
namespace DirectN;

public partial struct HMODULE : IEquatable<HMODULE>
{
    public static readonly HMODULE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMODULE value && Equals(value);
    public readonly bool Equals(HMODULE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMODULE left, HMODULE right) => left.Equals(right);
    public static bool operator !=(HMODULE left, HMODULE right) => !left.Equals(right);
}
