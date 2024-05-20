#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_credential_flags
public enum WMT_CREDENTIAL_FLAGS
{
    WMT_CREDENTIAL_SAVE = 1,
    WMT_CREDENTIAL_DONT_CACHE = 2,
    WMT_CREDENTIAL_CLEAR_TEXT = 4,
    WMT_CREDENTIAL_PROXY = 8,
    WMT_CREDENTIAL_ENCRYPT = 16,
}
