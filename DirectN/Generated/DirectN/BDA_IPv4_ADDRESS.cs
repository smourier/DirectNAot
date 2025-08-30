#nullable enable
namespace DirectN;

public partial struct BDA_IPv4_ADDRESS : IValueGet<byte[]>
{
    public InlineArrayByte_4 rgbAddress;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)rgbAddress).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)rgbAddress).ToArray();
}
