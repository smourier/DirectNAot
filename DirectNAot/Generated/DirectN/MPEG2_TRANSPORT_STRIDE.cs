namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectShow/mpeg2-transport-stride
[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG2_TRANSPORT_STRIDE
{
    public uint dwOffset;
    public uint dwPacketLength;
    public uint dwStride;
}
