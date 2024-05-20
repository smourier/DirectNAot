#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_viewport
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_VIEWPORT
{
    public int TopLeftX;
    public int TopLeftY;
    public uint Width;
    public uint Height;
    public float MinDepth;
    public float MaxDepth;
}
