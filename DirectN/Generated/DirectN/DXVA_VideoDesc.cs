#nullable enable
namespace DirectN;

public partial struct DXVA_VideoDesc
{
    public uint Size;
    public uint SampleWidth;
    public uint SampleHeight;
    public uint SampleFormat;
    public D3DFORMAT d3dFormat;
    public DXVA_Frequency InputSampleFreq;
    public DXVA_Frequency OutputFrameFreq;
}
