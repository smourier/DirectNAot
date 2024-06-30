#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-avicompressoptions
public partial struct AVICOMPRESSOPTIONS
{
    public uint fccType;
    public uint fccHandler;
    public uint dwKeyFrameEvery;
    public uint dwQuality;
    public uint dwBytesPerSecond;
    public uint dwFlags;
    public nint lpFormat;
    public uint cbFormat;
    public nint lpParms;
    public uint cbParms;
    public uint dwInterleaveEvery;
}
