#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_setpalettedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SETPALETTEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public nint lpDDPalette;
    public HRESULT ddRVal;
    public nint SetPalette;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Attach;
}
