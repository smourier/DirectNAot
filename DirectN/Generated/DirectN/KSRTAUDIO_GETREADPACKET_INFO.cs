#nullable enable
namespace DirectN;

public partial struct KSRTAUDIO_GETREADPACKET_INFO
{
    public uint PacketNumber;
    public uint Flags;
    public ulong PerformanceCounterValue;
    public BOOL MoreData;
}
