#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-avistreaminfoa
public partial struct AVISTREAMINFOA
{
    public uint fccType;
    public uint fccHandler;
    public uint dwFlags;
    public uint dwCaps;
    public ushort wPriority;
    public ushort wLanguage;
    public uint dwScale;
    public uint dwRate;
    public uint dwStart;
    public uint dwLength;
    public uint dwInitialFrames;
    public uint dwSuggestedBufferSize;
    public uint dwQuality;
    public uint dwSampleSize;
    public RECT rcFrame;
    public uint dwEditCount;
    public uint dwFormatChangeCount;
    public InlineArrayFoundationCHAR_64 szName;
}
