#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfvideocompressedinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoCompressedInfo
{
    public long AvgBitrate;
    public long AvgBitErrorRate;
    public uint MaxKeyFrameSpacing;
}
