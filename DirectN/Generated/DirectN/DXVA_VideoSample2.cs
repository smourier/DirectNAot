#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_VideoSample2
{
    public uint Size;
    public uint Reserved;
    public long rtStart;
    public long rtEnd;
    public uint SampleFormat;
    public uint SampleFlags;
    public nint lpDDSSrcSurface;
    public RECT rcSrc;
    public RECT rcDst;
    public InlineArrayDXVA_AYUVsample2_16 Palette;
}
