#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BitmapData
{
    public uint Width;
    public uint Height;
    public int Stride;
    public int PixelFormat;
    public nint Scan0;
    public nuint Reserved;
}
