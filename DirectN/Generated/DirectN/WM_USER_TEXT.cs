#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_user_text
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WM_USER_TEXT
{
    public PWSTR pwszDescription;
    public PWSTR pwszText;
}
