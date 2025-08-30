#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_omac
public partial struct OPM_OMAC : IValueGet<byte[]>
{
    public InlineArrayByte_16 abOMAC;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)abOMAC).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)abOMAC).ToArray();
}
