#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-sample_protection_version
public enum SAMPLE_PROTECTION_VERSION
{
    SAMPLE_PROTECTION_VERSION_NO = 0,
    SAMPLE_PROTECTION_VERSION_BASIC_LOKI = 1,
    SAMPLE_PROTECTION_VERSION_SCATTER = 2,
    SAMPLE_PROTECTION_VERSION_RC4 = 3,
    SAMPLE_PROTECTION_VERSION_AES128CTR = 4,
}
