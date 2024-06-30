#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9videodesc
public partial struct VMR9VideoDesc
{
    public uint dwSize;
    public uint dwSampleWidth;
    public uint dwSampleHeight;
    public VMR9_SampleFormat SampleFormat;
    public uint dwFourCC;
    public VMR9Frequency InputSampleFreq;
    public VMR9Frequency OutputFrameFreq;
}
