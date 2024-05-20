#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicimageparameters
[StructLayout(LayoutKind.Sequential)]
public partial struct WICImageParameters
{
    public D2D1_PIXEL_FORMAT PixelFormat;
    public float DpiX;
    public float DpiY;
    public float Top;
    public float Left;
    public uint PixelWidth;
    public uint PixelHeight;
}
