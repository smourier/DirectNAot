#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2bits/ns-mpeg2bits-mpeg_header_version_bits
public partial struct MPEG_HEADER_VERSION_BITS : IEquatable<MPEG_HEADER_VERSION_BITS>, IValueGet<byte>
{
    public static readonly MPEG_HEADER_VERSION_BITS Null = new();
    
    public byte _bitfield;
    
    public MPEG_HEADER_VERSION_BITS(byte value) => this._bitfield = value;
    public override string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is MPEG_HEADER_VERSION_BITS value && Equals(value);
    public readonly bool Equals(MPEG_HEADER_VERSION_BITS other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(MPEG_HEADER_VERSION_BITS left, MPEG_HEADER_VERSION_BITS right) => left.Equals(right);
    public static bool operator !=(MPEG_HEADER_VERSION_BITS left, MPEG_HEADER_VERSION_BITS right) => !left.Equals(right);
    public static implicit operator byte(MPEG_HEADER_VERSION_BITS value) => value._bitfield;
    public static implicit operator MPEG_HEADER_VERSION_BITS(byte value) => new(value);
    
    readonly byte IValueGet<byte>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
