#nullable enable
namespace DirectN;

public partial struct MPEG_HEADER_VERSION_BITS_MIDL : IEquatable<MPEG_HEADER_VERSION_BITS_MIDL>
{
    public static readonly MPEG_HEADER_VERSION_BITS_MIDL Null = new();
    
    public byte Bits;
    
    public MPEG_HEADER_VERSION_BITS_MIDL(byte value) => this.Bits = value;
    public override string ToString() => $"0x{Bits:x}";
    
    public override readonly bool Equals(object? obj) => obj is MPEG_HEADER_VERSION_BITS_MIDL value && Equals(value);
    public readonly bool Equals(MPEG_HEADER_VERSION_BITS_MIDL other) => other.Bits == Bits;
    public override readonly int GetHashCode() => Bits.GetHashCode();
    public static bool operator ==(MPEG_HEADER_VERSION_BITS_MIDL left, MPEG_HEADER_VERSION_BITS_MIDL right) => left.Equals(right);
    public static bool operator !=(MPEG_HEADER_VERSION_BITS_MIDL left, MPEG_HEADER_VERSION_BITS_MIDL right) => !left.Equals(right);
    public static implicit operator byte(MPEG_HEADER_VERSION_BITS_MIDL value) => value.Bits;
    public static implicit operator MPEG_HEADER_VERSION_BITS_MIDL(byte value) => new(value);
}
