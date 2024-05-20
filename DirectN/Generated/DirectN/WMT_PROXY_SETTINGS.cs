#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_proxy_settings
public enum WMT_PROXY_SETTINGS
{
    WMT_PROXY_SETTING_NONE = 0,
    WMT_PROXY_SETTING_MANUAL = 1,
    WMT_PROXY_SETTING_AUTO = 2,
    WMT_PROXY_SETTING_BROWSER = 3,
    WMT_PROXY_SETTING_MAX = 4,
}
