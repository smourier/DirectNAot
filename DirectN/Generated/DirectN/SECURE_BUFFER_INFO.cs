#nullable enable
namespace DirectN;

public partial struct SECURE_BUFFER_INFO
{
    public Guid guidBufferIdentifier;
    public uint cbBufferSize;
    public uint cbCaptured;
    public InlineArrayUInt64_16 ullReserved;
}
