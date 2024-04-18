namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_bitmap_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BITMAP_PROPERTIES
{
    public D2D1_PIXEL_FORMAT pixelFormat;
    public float dpiX;
    public float dpiY;
}
