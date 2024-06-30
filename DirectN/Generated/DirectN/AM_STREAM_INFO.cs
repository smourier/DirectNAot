#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-am_stream_info
public partial struct AM_STREAM_INFO
{
    public long tStart;
    public long tStop;
    public uint dwStartCookie;
    public uint dwStopCookie;
    public uint dwFlags;
}
