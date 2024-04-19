namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_hmsf_timecode
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_HMSF_TIMECODE
{
    public byte bHours;
    public byte bMinutes;
    public byte bSeconds;
    public byte bFrames;
}
