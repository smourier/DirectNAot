#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_videoattributes
public partial struct DVD_VideoAttributes
{
    public BOOL fPanscanPermitted;
    public BOOL fLetterboxPermitted;
    public uint ulAspectX;
    public uint ulAspectY;
    public uint ulFrameRate;
    public uint ulFrameHeight;
    public DVD_VIDEO_COMPRESSION Compression;
    public BOOL fLine21Field1InGOP;
    public BOOL fLine21Field2InGOP;
    public uint ulSourceResolutionX;
    public uint ulSourceResolutionY;
    public BOOL fIsSourceLetterboxed;
    public BOOL fIsFilmMode;
}
