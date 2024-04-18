namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_bitmap_properties1
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_BITMAP_PROPERTIES1
{
    public D2D1_PIXEL_FORMAT pixelFormat;
    public float dpiX;
    public float dpiY;
    public D2D1_BITMAP_OPTIONS bitmapOptions;
    public nint colorContext;
}
