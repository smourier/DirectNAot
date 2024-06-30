#nullable enable
namespace DirectN;

public partial struct BDA_DISEQC_RESPONSE
{
    public uint ulRequestId;
    public uint ulPacketLength;
    public InlineArrayByte_8 argbPacketData;
}
