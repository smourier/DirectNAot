#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_karaokeattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_KaraokeAttributes
{
    public byte bVersion;
    public BOOL fMasterOfCeremoniesInGuideVocal1;
    public BOOL fDuet;
    public DVD_KARAOKE_ASSIGNMENT ChannelAssignment;
    public InlineArrayUInt16_8 wChannelContents;
}
