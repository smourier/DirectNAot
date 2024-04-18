namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicbitmapplane
[StructLayout(LayoutKind.Sequential)]
public partial struct WICBitmapPlane
{
    public Guid Format;
    public nint pbBuffer;
    public uint cbStride;
    public uint cbBufferSize;
}
