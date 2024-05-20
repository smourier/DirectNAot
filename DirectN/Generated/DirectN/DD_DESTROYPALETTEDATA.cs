#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_destroypalettedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DESTROYPALETTEDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public HRESULT ddRVal;
    public nint DestroyPalette;
}
