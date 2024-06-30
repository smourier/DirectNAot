#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/mpeg2-transport-stride
public partial struct MPEG2_TRANSPORT_STRIDE
{
    public uint dwOffset;
    public uint dwPacketLength;
    public uint dwStride;
}
