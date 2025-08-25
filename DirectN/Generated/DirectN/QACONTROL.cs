#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/ns-ocidl-qacontrol
public partial struct QACONTROL
{
    public uint cbSize;
    public uint dwMiscStatus;
    public uint dwViewStatus;
    public uint dwEventCookie;
    public uint dwPropNotifyCookie;
    public uint dwPointerActivationPolicy;
}
