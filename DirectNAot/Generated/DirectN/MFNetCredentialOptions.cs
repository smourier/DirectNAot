#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfnetcredentialoptions
public enum MFNetCredentialOptions
{
    MFNET_CREDENTIAL_SAVE = 1,
    MFNET_CREDENTIAL_DONT_CACHE = 2,
    MFNET_CREDENTIAL_ALLOW_CLEAR_TEXT = 4,
}
