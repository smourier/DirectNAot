#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9caps/ns-d3d9caps-d3doverlaycaps
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DOVERLAYCAPS
{
    public uint Caps;
    public uint MaxOverlayDisplayWidth;
    public uint MaxOverlayDisplayHeight;
}
