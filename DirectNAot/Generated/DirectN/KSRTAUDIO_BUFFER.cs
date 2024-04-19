namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER
{
    public nint BufferAddress;
    public uint ActualBufferSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CallMemoryBarrier;
}
