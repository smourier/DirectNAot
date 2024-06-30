#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioapotypes/ns-audioapotypes-apo_connection_property
public partial struct APO_CONNECTION_PROPERTY
{
    public nuint pBuffer;
    public uint u32ValidFrameCount;
    public APO_BUFFER_FLAGS u32BufferFlags;
    public uint u32Signature;
}
