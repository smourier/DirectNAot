#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_palette_local
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_PALETTE_LOCAL
{
    public uint dwReserved0;
    public nuint dwReserved1;
}
