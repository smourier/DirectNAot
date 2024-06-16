#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER
{
    public nint BufferAddress;
    public uint ActualBufferSize;
    public BOOL CallMemoryBarrier;
}
