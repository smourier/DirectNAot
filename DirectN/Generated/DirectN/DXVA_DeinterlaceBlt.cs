#nullable enable
namespace DirectN;

public partial struct DXVA_DeinterlaceBlt
{
    public uint Size;
    public uint Reserved;
    public long rtTarget;
    public RECT DstRect;
    public RECT SrcRect;
    public uint NumSourceSurfaces;
    public float Alpha;
    public InlineArrayDXVA_VideoSample_32 Source;
}
