#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_simpleratechange
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_SimpleRateChange
{
    public long StartTime;
    public int Rate;
}
