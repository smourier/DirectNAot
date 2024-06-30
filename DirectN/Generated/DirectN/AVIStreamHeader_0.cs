#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/avifmt/ns-avifmt-avistreamheader
public partial struct AVIStreamHeader
{
    public uint fccType;
    public uint fccHandler;
    public uint dwFlags;
    public ushort wPriority;
    public ushort wLanguage;
    public uint dwInitialFrames;
    public uint dwScale;
    public uint dwRate;
    public uint dwStart;
    public uint dwLength;
    public uint dwSuggestedBufferSize;
    public uint dwQuality;
    public uint dwSampleSize;
    public RECT rcFrame;
}
