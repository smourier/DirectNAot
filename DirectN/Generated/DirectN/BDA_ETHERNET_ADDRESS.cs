#nullable enable
namespace DirectN;

public partial struct BDA_ETHERNET_ADDRESS : IValueGet<byte[]>
{
    public InlineArrayByte_6 rgbAddress;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)rgbAddress).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)rgbAddress).ToArray();
}
