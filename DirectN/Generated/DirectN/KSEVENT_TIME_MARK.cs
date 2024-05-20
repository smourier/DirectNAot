#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSEVENT_TIME_MARK
{
    public KSEVENTDATA EventData;
    public long MarkTime;
}
