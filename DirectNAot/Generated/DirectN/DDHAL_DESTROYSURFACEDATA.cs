namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYSURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint DestroySurface;
}
