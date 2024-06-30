#nullable enable
namespace DirectN;

public partial struct DXVA_DeinterlaceBltEx32
{
    public uint Size;
    public DXVA_AYUVsample2 BackgroundColor;
    public RECT rcTarget;
    public long rtTarget;
    public uint NumSourceSurfaces;
    public float Alpha;
    public InlineArrayDXVA_VideoSample32_32 Source;
    public uint DestinationFormat;
    public uint DestinationFlags;
}
