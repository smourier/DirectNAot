#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_drmla_trust
public enum WMT_DRMLA_TRUST
{
    WMT_DRMLA_UNTRUSTED = 0,
    WMT_DRMLA_TRUSTED = 1,
    WMT_DRMLA_TAMPERED = 2,
}
