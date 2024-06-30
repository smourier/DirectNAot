#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfvideoformat
public partial struct MFVIDEOFORMAT
{
    public uint dwSize;
    public MFVideoInfo videoInfo;
    public Guid guidFormat;
    public MFVideoCompressedInfo compressedInfo;
    public MFVideoSurfaceInfo surfaceInfo;
}
