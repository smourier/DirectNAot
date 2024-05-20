#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2bits/ns-mpeg2bits-mpeg_header_bits
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG_HEADER_BITS
{
    public ushort _bitfield;
}
