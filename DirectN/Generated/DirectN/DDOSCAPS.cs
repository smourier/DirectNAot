#nullable enable
namespace DirectN;

public partial struct DDOSCAPS : IEquatable<DDOSCAPS>, IValueGet<uint>
{
    public static readonly DDOSCAPS Null = new();
    
    public uint dwCaps;
    
    public DDOSCAPS(uint value) => this.dwCaps = value;
    public override readonly string ToString() => $"0x{dwCaps:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDOSCAPS value && Equals(value);
    public readonly bool Equals(DDOSCAPS other) => other.dwCaps == dwCaps;
    public override readonly int GetHashCode() => dwCaps.GetHashCode();
    public static bool operator ==(DDOSCAPS left, DDOSCAPS right) => left.Equals(right);
    public static bool operator !=(DDOSCAPS left, DDOSCAPS right) => !left.Equals(right);
    public static implicit operator uint(DDOSCAPS value) => value.dwCaps;
    public static implicit operator DDOSCAPS(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => dwCaps;
    readonly object? IValueGet.GetValue() => dwCaps;
}
