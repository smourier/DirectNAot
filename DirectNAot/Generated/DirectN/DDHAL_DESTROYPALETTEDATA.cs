namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYPALETTEDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public HRESULT ddRVal;
    public nint DestroyPalette;
}
