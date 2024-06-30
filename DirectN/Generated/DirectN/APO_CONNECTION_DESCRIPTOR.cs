#nullable enable
namespace DirectN;

public partial struct APO_CONNECTION_DESCRIPTOR
{
    public APO_CONNECTION_BUFFER_TYPE Type;
    public nuint pBuffer;
    public uint u32MaxFrameCount;
    public nint pFormat;
    public uint u32Signature;
}
