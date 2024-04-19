namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_destroysurfacedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DESTROYSURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public HRESULT ddRVal;
    public nint DestroySurface;
}
