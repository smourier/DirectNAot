#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_BITMAP_DATA_BGRA32
{
    public uint width;
    public uint height;
    public nint pixels;
}
