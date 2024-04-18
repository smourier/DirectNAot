namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_ADDATTACHEDSURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public nint lpSurfAttached;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint AddAttachedSurface;
}
