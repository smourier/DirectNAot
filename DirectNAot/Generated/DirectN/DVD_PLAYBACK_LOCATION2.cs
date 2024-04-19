namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_playback_location2
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_PLAYBACK_LOCATION2
{
    public uint TitleNum;
    public uint ChapterNum;
    public DVD_HMSF_TIMECODE TimeCode;
    public uint TimeCodeFlags;
}
