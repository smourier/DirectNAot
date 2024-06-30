#nullable enable
namespace DirectN;

public partial struct VIDEO_MEMORY_INFORMATION
{
    public nint VideoRamBase;
    public uint VideoRamLength;
    public nint FrameBufferBase;
    public uint FrameBufferLength;
}
