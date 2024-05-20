#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ne-mfapi-mfsampleencryptionprotectionscheme
public enum MFSampleEncryptionProtectionScheme
{
    MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_NONE = 0,
    MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CTR = 1,
    MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CBC = 2,
}
