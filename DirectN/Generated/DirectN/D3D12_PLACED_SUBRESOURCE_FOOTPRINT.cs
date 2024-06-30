#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_placed_subresource_footprint
public partial struct D3D12_PLACED_SUBRESOURCE_FOOTPRINT
{
    public ulong Offset;
    public D3D12_SUBRESOURCE_FOOTPRINT Footprint;
}
