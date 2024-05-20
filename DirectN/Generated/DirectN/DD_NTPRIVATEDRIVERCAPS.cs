#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_ntprivatedrivercaps
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_NTPRIVATEDRIVERCAPS
{
    public uint dwSize;
    public uint dwPrivateCaps;
}
