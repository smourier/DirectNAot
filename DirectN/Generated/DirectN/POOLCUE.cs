#nullable enable
namespace DirectN;

public partial struct POOLCUE : IEquatable<POOLCUE>
{
    public static readonly POOLCUE Null = new();
    
    public uint ulOffset;
    
    public POOLCUE(uint value) => this.ulOffset = value;
    public override string ToString() => $"0x{ulOffset:x}";
    
    public override readonly bool Equals(object? obj) => obj is POOLCUE value && Equals(value);
    public readonly bool Equals(POOLCUE other) => other.ulOffset == ulOffset;
    public override readonly int GetHashCode() => ulOffset.GetHashCode();
    public static bool operator ==(POOLCUE left, POOLCUE right) => left.Equals(right);
    public static bool operator !=(POOLCUE left, POOLCUE right) => !left.Equals(right);
    public static implicit operator uint(POOLCUE value) => value.ulOffset;
    public static implicit operator POOLCUE(uint value) => new(value);
}
