#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-jpeg-dc-huffman-table
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_JPEG_DC_HUFFMAN_TABLE
{
    public InlineArrayByte12 CodeCounts;
    public InlineArrayByte12 CodeValues;
}
