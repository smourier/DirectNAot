#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddsetstateoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDSETSTATEOUTINFO
{
    public BOOL bSoftwareAutoflip;
    public uint dwSurfaceIndex;
    public uint dwVBISurfaceIndex;
}
