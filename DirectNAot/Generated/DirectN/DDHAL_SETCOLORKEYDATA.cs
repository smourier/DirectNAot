namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETCOLORKEYDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwFlags;
    public DDCOLORKEY ckNew;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetColorKey;
}
