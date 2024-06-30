#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcommon/ns-dcommon-d2d1_pixel_format
public partial struct D2D1_PIXEL_FORMAT
{
    public DXGI_FORMAT format;
    public D2D1_ALPHA_MODE alphaMode;
}
