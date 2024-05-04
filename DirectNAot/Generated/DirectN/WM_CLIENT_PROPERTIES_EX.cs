#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_client_properties_ex
[StructLayout(LayoutKind.Sequential)]
public partial struct WM_CLIENT_PROPERTIES_EX
{
    public uint cbSize;
    public PWSTR pwszIPAddress;
    public PWSTR pwszPort;
    public PWSTR pwszDNSName;
}
