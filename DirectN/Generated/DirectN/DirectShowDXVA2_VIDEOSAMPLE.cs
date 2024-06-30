#nullable enable
namespace DirectN;

public partial struct DirectShowDXVA2_VIDEOSAMPLE
{
    public long Start;
    public long End;
    public DXVA2_ExtendedFormat SampleFormat;
    public uint SampleFlags;
    public nint SrcResource;
    public RECT SrcRect;
    public RECT DstRect;
    public InlineArrayDXVA2_AYUVSample8_16 Pal;
    public DXVA2_Fixed32 PlanarAlpha;
}
