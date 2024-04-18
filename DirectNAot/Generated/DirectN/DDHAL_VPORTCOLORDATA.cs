namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_VPORTCOLORDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpColorData;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint ColorControl;
}
