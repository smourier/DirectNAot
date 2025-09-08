#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2bits/ns-mpeg2bits-mpeg_header_bits
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_HEADER_BITS : IEquatable<MPEG_HEADER_BITS>, IValueGet<ushort>
{
    public static readonly MPEG_HEADER_BITS Null = new();
    
    public ushort _bitfield;
    
    public MPEG_HEADER_BITS(ushort value) => this._bitfield = value;
    public override readonly string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is MPEG_HEADER_BITS value && Equals(value);
    public readonly bool Equals(MPEG_HEADER_BITS other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(MPEG_HEADER_BITS left, MPEG_HEADER_BITS right) => left.Equals(right);
    public static bool operator !=(MPEG_HEADER_BITS left, MPEG_HEADER_BITS right) => !left.Equals(right);
    public static implicit operator ushort(MPEG_HEADER_BITS value) => value._bitfield;
    public static implicit operator MPEG_HEADER_BITS(ushort value) => new(value);
    
    readonly ushort IValueGet<ushort>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
