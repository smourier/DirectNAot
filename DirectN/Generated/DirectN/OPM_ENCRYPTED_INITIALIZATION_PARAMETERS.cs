#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_encrypted_initialization_parameters
public partial struct OPM_ENCRYPTED_INITIALIZATION_PARAMETERS : IValueGet<byte[]>
{
    public InlineArrayByte_256 abEncryptedInitializationParameters;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)abEncryptedInitializationParameters).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)abEncryptedInitializationParameters).ToArray();
}
