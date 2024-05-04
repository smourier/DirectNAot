#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_cancreatesurfacedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CANCREATESURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurfaceDesc;
    public uint bIsDifferentPixelFormat;
    public HRESULT ddRVal;
    public nint CanCreateSurface;
}
