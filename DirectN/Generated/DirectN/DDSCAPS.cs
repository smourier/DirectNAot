#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddscaps
public partial struct DDSCAPS : IEquatable<DDSCAPS>, IValueGet<uint>
{
    public static readonly DDSCAPS Null = new();
    
    public uint dwCaps;
    
    public DDSCAPS(uint value) => this.dwCaps = value;
    public override readonly string ToString() => $"0x{dwCaps:x}";
    
    public override readonly bool Equals(object? obj) => obj is DDSCAPS value && Equals(value);
    public readonly bool Equals(DDSCAPS other) => other.dwCaps == dwCaps;
    public override readonly int GetHashCode() => dwCaps.GetHashCode();
    public static bool operator ==(DDSCAPS left, DDSCAPS right) => left.Equals(right);
    public static bool operator !=(DDSCAPS left, DDSCAPS right) => !left.Equals(right);
    public static implicit operator uint(DDSCAPS value) => value.dwCaps;
    public static implicit operator DDSCAPS(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => dwCaps;
    readonly object? IValueGet.GetValue() => dwCaps;
}
