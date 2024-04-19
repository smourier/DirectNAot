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
    public FoundationRECT rcSrc;
    public FoundationRECT rcDst;
    public InlineArrayDXVA_AYUVsample216 Palette;
}
