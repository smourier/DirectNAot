#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_DISEQC_SEND
{
    public uint ulRequestId;
    public uint ulPacketLength;
    public InlineArrayByte_8 argbPacketData;
}
