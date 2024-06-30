#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportbandwidthdata
public partial struct DD_GETVPORTBANDWIDTHDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lpddpfFormat;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwFlags;
    public nint lpBandwidth;
    public HRESULT ddRVal;
    public nint GetVideoPortBandwidth;
}
