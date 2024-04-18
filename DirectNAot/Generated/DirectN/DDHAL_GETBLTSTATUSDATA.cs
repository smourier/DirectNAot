namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETBLTSTATUSDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetBltStatus;
}
