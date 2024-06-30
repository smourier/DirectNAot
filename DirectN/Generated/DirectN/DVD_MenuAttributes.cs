#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_menuattributes
public partial struct DVD_MenuAttributes
{
    public InlineArrayBOOL_8 fCompatibleRegion;
    public DVD_VideoAttributes VideoAttributes;
    public BOOL fAudioPresent;
    public DVD_AudioAttributes AudioAttributes;
    public BOOL fSubpicturePresent;
    public DVD_SubpictureAttributes SubpictureAttributes;
}
