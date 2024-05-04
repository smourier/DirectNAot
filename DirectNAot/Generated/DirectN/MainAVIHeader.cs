#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MainAVIHeader
{
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
