#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_geometry_aabbs_desc
public partial struct D3D12_RAYTRACING_GEOMETRY_AABBS_DESC
{
    public ulong AABBCount;
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE AABBs;
}
