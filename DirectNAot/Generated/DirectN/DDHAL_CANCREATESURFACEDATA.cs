namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CANCREATESURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurfaceDesc;
    public uint bIsDifferentPixelFormat;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint CanCreateSurface;
}
