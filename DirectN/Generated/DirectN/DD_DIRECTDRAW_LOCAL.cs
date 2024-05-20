#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_directdraw_local
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DIRECTDRAW_LOCAL
{
    public nint lpGbl;
}
