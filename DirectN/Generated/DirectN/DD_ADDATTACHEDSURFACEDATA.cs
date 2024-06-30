#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_addattachedsurfacedata
public partial struct DD_ADDATTACHEDSURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public nint lpSurfAttached;
    public HRESULT ddRVal;
    public nint AddAttachedSurface;
}
