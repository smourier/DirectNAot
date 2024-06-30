#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_render_target_properties
public partial struct D2D1_RENDER_TARGET_PROPERTIES
{
    public D2D1_RENDER_TARGET_TYPE type;
    public D2D1_PIXEL_FORMAT pixelFormat;
    public float dpiX;
    public float dpiY;
    public D2D1_RENDER_TARGET_USAGE usage;
    public D2D1_FEATURE_LEVEL minLevel;
}
