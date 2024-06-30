#nullable enable
namespace DirectN;

public partial struct DXVA_DeinterlaceCaps
{
    public uint Size;
    public uint NumPreviousOutputFrames;
    public uint InputPool;
    public uint NumForwardRefSamples;
    public uint NumBackwardRefSamples;
    public D3DFORMAT d3dOutputFormat;
    public DXVA_VideoProcessCaps VideoProcessingCaps;
    public DXVA_DeinterlaceTech DeinterlaceTechnology;
}
