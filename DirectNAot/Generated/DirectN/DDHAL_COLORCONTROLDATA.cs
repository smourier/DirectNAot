namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_COLORCONTROLDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public nint lpColorData;
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint ColorControl;
}
