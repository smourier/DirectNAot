#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-amcoppsignature
public partial struct AMCOPPSignature : IValueGet<byte[]>
{
    public InlineArrayByte_256 Signature;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)Signature).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)Signature).ToArray();
}
