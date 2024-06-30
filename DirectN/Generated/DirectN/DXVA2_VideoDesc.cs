#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_videodesc
public partial struct DXVA2_VideoDesc
{
    public uint SampleWidth;
    public uint SampleHeight;
    public DXVA2_ExtendedFormat SampleFormat;
    public D3DFORMAT Format;
    public DXVA2_Frequency InputSampleFreq;
    public DXVA2_Frequency OutputFrameFreq;
    public uint UABProtectionLevel;
    public uint Reserved;
}
