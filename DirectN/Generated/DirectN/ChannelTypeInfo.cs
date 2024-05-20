#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ChannelTypeInfo
{
    public ChannelType channelType;
    public ulong timeStamp;
}
