namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DRVSETCOLORKEYDATA
{
    public nint lpDDSurface;
    public uint dwFlags;
    public DDCOLORKEY ckNew;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetColorKey;
}
