#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tile_shape
public partial struct D3D12_TILE_SHAPE
{
    public uint WidthInTexels;
    public uint HeightInTexels;
    public uint DepthInTexels;
}
