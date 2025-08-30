#nullable enable
namespace DirectN;

public partial struct KS_DVDCOPY_DISCKEY : IValueGet<byte[]>
{
    public InlineArrayByte_2048 DiscKey;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)DiscKey).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)DiscKey).ToArray();
}
