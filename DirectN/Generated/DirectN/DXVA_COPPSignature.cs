#nullable enable
namespace DirectN;

public partial struct DXVA_COPPSignature : IValueGet<byte[]>
{
    public InlineArrayByte_256 Signature;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)Signature).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)Signature).ToArray();
}
