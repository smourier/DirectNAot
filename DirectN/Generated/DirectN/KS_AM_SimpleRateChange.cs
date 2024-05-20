#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_AM_SimpleRateChange
{
    public long StartTime;
    public int Rate;
}
