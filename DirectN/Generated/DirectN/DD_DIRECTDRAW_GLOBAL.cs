#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_directdraw_global
public partial struct DD_DIRECTDRAW_GLOBAL
{
    public nint dhpdev;
    public nuint dwReserved1;
    public nuint dwReserved2;
    public nint lpDDVideoPortCaps;
}
