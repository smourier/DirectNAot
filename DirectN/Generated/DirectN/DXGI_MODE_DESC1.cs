#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_mode_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_MODE_DESC1
{
    public uint Width;
    public uint Height;
    public DXGI_RATIONAL RefreshRate;
    public DXGI_FORMAT Format;
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    public DXGI_MODE_SCALING Scaling;
    public BOOL Stereo;
}
