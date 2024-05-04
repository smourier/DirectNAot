#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER32
{
    public uint BufferAddress;
    public uint ActualBufferSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CallMemoryBarrier;
}
