#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_random_number
public partial struct OPM_RANDOM_NUMBER : IValueGet<byte[]>
{
    public InlineArrayByte_16 abRandomNumber;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)abRandomNumber).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)abRandomNumber).ToArray();
}
