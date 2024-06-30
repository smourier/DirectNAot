#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-jpeg-ac-huffman-table
public partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
{
    public InlineArrayByte_16 CodeCounts;
    public InlineArrayByte_162 CodeValues;
}
