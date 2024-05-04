#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_surface_int
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SURFACE_INT
{
    public nint lpLcl;
}
