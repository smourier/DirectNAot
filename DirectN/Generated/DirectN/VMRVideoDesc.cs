#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrvideodesc
public partial struct VMRVideoDesc
{
    public uint dwSize;
    public uint dwSampleWidth;
    public uint dwSampleHeight;
    public BOOL SingleFieldPerSample;
    public uint dwFourCC;
    public VMRFrequency InputSampleFreq;
    public VMRFrequency OutputFrameFreq;
}
