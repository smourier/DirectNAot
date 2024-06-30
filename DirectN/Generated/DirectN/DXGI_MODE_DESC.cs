#nullable enable
namespace DirectN;

public partial struct DXGI_MODE_DESC
{
    public uint Width;
    public uint Height;
    public DXGI_RATIONAL RefreshRate;
    public DXGI_FORMAT Format;
    public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
    public DXGI_MODE_SCALING Scaling;
}
