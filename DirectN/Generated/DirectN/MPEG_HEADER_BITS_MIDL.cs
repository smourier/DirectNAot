#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_HEADER_BITS_MIDL : IEquatable<MPEG_HEADER_BITS_MIDL>, IValueGet<ushort>
{
    public static readonly MPEG_HEADER_BITS_MIDL Null = new();
    
    public ushort Bits;
    
    public MPEG_HEADER_BITS_MIDL(ushort value) => this.Bits = value;
    public override readonly string ToString() => $"0x{Bits:x}";
    
    public override readonly bool Equals(object? obj) => obj is MPEG_HEADER_BITS_MIDL value && Equals(value);
    public readonly bool Equals(MPEG_HEADER_BITS_MIDL other) => other.Bits == Bits;
    public override readonly int GetHashCode() => Bits.GetHashCode();
    public static bool operator ==(MPEG_HEADER_BITS_MIDL left, MPEG_HEADER_BITS_MIDL right) => left.Equals(right);
    public static bool operator !=(MPEG_HEADER_BITS_MIDL left, MPEG_HEADER_BITS_MIDL right) => !left.Equals(right);
    public static implicit operator ushort(MPEG_HEADER_BITS_MIDL value) => value.Bits;
    public static implicit operator MPEG_HEADER_BITS_MIDL(ushort value) => new(value);
    
    readonly ushort IValueGet<ushort>.GetValue() => Bits;
    readonly object? IValueGet.GetValue() => Bits;
}
