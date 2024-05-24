#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_buffer_wma
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_BUFFER_WMA
{
    public nint pDecodedPacketCumulativeBytes;
    public uint PacketCount;
}
