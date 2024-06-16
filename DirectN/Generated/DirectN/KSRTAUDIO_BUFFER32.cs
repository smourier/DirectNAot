#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER32
{
    public uint BufferAddress;
    public uint ActualBufferSize;
    public BOOL CallMemoryBarrier;
}
