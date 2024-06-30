#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetcurrentautoflipoutinfo
public partial struct DDGETCURRENTAUTOFLIPOUTINFO
{
    public uint dwSurfaceIndex;
    public uint dwVBISurfaceIndex;
}
