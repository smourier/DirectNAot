namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSEVENT_TIME_INTERVAL
{
    public KSEVENTDATA EventData;
    public long TimeBase;
    public long Interval;
}
