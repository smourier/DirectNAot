namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_resource_barrier_type
public enum D3D12_RESOURCE_BARRIER_TYPE
{
    D3D12_RESOURCE_BARRIER_TYPE_TRANSITION = 0,
    D3D12_RESOURCE_BARRIER_TYPE_ALIASING = 1,
    D3D12_RESOURCE_BARRIER_TYPE_UAV = 2,
}
