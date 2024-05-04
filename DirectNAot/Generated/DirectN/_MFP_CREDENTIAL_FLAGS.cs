#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ne-mfplay-_mfp_credential_flags
public enum _MFP_CREDENTIAL_FLAGS
{
    MFP_CREDENTIAL_PROMPT = 1,
    MFP_CREDENTIAL_SAVE = 2,
    MFP_CREDENTIAL_DO_NOT_CACHE = 4,
    MFP_CREDENTIAL_CLEAR_TEXT = 8,
    MFP_CREDENTIAL_PROXY = 16,
    MFP_CREDENTIAL_LOGGED_ON_USER = 32,
}
