namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-jpeg-ac-huffman-table
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
{
    public InlineArrayByte16 CodeCounts;
    public InlineArrayByte162 CodeValues;
}
