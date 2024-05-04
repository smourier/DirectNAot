#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-avistreaminfow
[StructLayout(LayoutKind.Sequential)]
public partial struct AVISTREAMINFOW
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
    public InlineArraySystemChar64 szName;
}
