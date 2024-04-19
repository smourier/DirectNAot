namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_GETREADPACKET_INFO
{
    public uint PacketNumber;
    public uint Flags;
    public ulong PerformanceCounterValue;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MoreData;
}
