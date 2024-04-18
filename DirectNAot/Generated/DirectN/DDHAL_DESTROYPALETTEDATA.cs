namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYPALETTEDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint DestroyPalette;
}
