#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/timeapi/ns-timeapi-timecaps
[StructLayout(LayoutKind.Sequential)]
public partial struct TIMECAPS
{
    public uint wPeriodMin;
    public uint wPeriodMax;
}
