namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CREATEPALETTEDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public nint lpColorTable;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint CreatePalette;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool is_excl;
}
