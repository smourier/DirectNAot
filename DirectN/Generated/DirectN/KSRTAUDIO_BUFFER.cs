#nullable enable
namespace DirectN;

public partial struct KSRTAUDIO_BUFFER
{
    public nint BufferAddress;
    public uint ActualBufferSize;
    public BOOL CallMemoryBarrier;
}
