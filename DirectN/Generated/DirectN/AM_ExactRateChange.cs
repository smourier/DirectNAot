#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_exactratechange
public partial struct AM_ExactRateChange
{
    public long OutputZeroTime;
    public int Rate;
}
