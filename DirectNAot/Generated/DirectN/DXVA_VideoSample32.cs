namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_VideoSample32
{
    public long rtStart;
    public long rtEnd;
    public uint SampleFormat;
    public uint SampleFlags;
    public uint lpDDSSrcSurface;
    public FoundationRECT rcSrc;
    public FoundationRECT rcDst;
    public InlineArrayDXVA_AYUVsample216 Palette;
}
