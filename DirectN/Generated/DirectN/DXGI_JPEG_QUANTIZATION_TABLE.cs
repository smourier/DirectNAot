#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-jpeg-quantization-table
public partial struct DXGI_JPEG_QUANTIZATION_TABLE : IValueGet<byte[]>
{
    public InlineArrayByte_64 Elements;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)Elements).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)Elements).ToArray();
}
