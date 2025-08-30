#nullable enable
namespace DirectN;

public partial struct DXGI_HDR_METADATA_HDR10PLUS : IValueGet<byte[]>
{
    public InlineArrayByte_72 Data;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)Data).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)Data).ToArray();
}
