#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ChannelChangeInfo
{
    public ChannelChangeSpanningEvent_State state;
    public ulong TimeStamp;
}
