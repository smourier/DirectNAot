#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_address_accessentry
public partial struct WM_ADDRESS_ACCESSENTRY
{
    public uint dwIPAddress;
    public uint dwMask;
}
