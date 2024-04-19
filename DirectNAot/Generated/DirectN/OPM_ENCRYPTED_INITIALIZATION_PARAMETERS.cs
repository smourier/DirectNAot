namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_encrypted_initialization_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_ENCRYPTED_INITIALIZATION_PARAMETERS
{
    public InlineArrayByte256 abEncryptedInitializationParameters;
}
