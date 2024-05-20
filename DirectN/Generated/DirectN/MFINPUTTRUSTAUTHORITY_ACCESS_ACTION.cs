#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfinputtrustauthority_access_action
[StructLayout(LayoutKind.Sequential)]
public partial struct MFINPUTTRUSTAUTHORITY_ACCESS_ACTION
{
    public MFPOLICYMANAGER_ACTION Action;
    public nint pbTicket;
    public uint cbTicket;
}
