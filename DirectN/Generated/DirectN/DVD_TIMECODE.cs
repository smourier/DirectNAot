#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_timecode
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_TIMECODE
{
    public uint _bitfield;
}
