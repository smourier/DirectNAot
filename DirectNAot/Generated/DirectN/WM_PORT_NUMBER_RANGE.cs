#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wm_port_number_range
[StructLayout(LayoutKind.Sequential)]
public partial struct WM_PORT_NUMBER_RANGE
{
    public ushort wPortBegin;
    public ushort wPortEnd;
}
