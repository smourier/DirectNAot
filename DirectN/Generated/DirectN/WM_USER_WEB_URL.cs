#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_user_web_url
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WM_USER_WEB_URL
{
    public PWSTR pwszDescription;
    public PWSTR pwszURL;
}
