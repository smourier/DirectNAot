#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETPALETTEDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public nint lpDDPalette;
    public HRESULT ddRVal;
    public nint SetPalette;
    public BOOL Attach;
}
