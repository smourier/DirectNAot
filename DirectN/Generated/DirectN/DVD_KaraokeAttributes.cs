#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_karaokeattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_KaraokeAttributes
{
    public byte bVersion;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fMasterOfCeremoniesInGuideVocal1;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fDuet;
    public DVD_KARAOKE_ASSIGNMENT ChannelAssignment;
    public InlineArrayUInt16_8 wChannelContents;
}
