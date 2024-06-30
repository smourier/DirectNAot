#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_playback_location
public partial struct DVD_PLAYBACK_LOCATION
{
    public uint TitleNum;
    public uint ChapterNum;
    public uint TimeCode;
}
