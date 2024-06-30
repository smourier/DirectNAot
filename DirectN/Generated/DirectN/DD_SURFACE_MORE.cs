#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_surface_more
public partial struct DD_SURFACE_MORE
{
    public uint dwMipMapCount;
    public nint lpVideoPort;
    public uint dwOverlayFlags;
    public DDSCAPSEX ddsCapsEx;
    public uint dwSurfaceHandle;
}
