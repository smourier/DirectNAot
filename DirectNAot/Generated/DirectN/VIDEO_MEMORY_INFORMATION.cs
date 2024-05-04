#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_MEMORY_INFORMATION
{
    public nint VideoRamBase;
    public uint VideoRamLength;
    public nint FrameBufferBase;
    public uint FrameBufferLength;
}
