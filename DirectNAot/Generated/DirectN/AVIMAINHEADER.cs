#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avimainheader
[StructLayout(LayoutKind.Sequential)]
public partial struct AVIMAINHEADER
{
    public uint fcc;
    public uint cb;
    public uint dwMicroSecPerFrame;
    public uint dwMaxBytesPerSec;
    public uint dwPaddingGranularity;
    public uint dwFlags;
    public uint dwTotalFrames;
    public uint dwInitialFrames;
    public uint dwStreams;
    public uint dwSuggestedBufferSize;
    public uint dwWidth;
    public uint dwHeight;
    public InlineArrayUInt324 dwReserved;
}
