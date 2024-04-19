namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_client_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct WM_CLIENT_PROPERTIES
{
    public uint dwIPAddress;
    public uint dwPort;
}
