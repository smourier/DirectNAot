#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_depth_stencil_value
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DEPTH_STENCIL_VALUE
{
    public float Depth;
    public byte Stencil;
}
