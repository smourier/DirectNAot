#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-jpeg-quantization-table
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_JPEG_QUANTIZATION_TABLE
{
    public InlineArrayByte64 Elements;
}
