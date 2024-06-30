#nullable enable
namespace DirectN;

public partial struct HSEMAPHORE : IEquatable<HSEMAPHORE>
{
    public static readonly HSEMAPHORE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HSEMAPHORE value && Equals(value);
    public readonly bool Equals(HSEMAPHORE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HSEMAPHORE left, HSEMAPHORE right) => left.Equals(right);
    public static bool operator !=(HSEMAPHORE left, HSEMAPHORE right) => !left.Equals(right);
}
