namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_DeinterlaceBltEx
{
    public uint Size;
    public DXVA_AYUVsample2 BackgroundColor;
    public FoundationRECT rcTarget;
    public long rtTarget;
    public uint NumSourceSurfaces;
    public float Alpha;
    public InlineArrayDXVA_VideoSample232 Source;
    public uint DestinationFormat;
    public uint DestinationFlags;
}
