#nullable enable
namespace DirectN;

public partial struct DXVA_VideoSample
{
    public long rtStart;
    public long rtEnd;
    public DXVA_SampleFormat SampleFormat;
    public nint lpDDSSrcSurface;
}
