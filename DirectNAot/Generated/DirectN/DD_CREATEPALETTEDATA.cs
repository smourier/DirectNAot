namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createpalettedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CREATEPALETTEDATA
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
