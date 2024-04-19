namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_resource_barrier_flags
[Flags]
public enum D3D12_RESOURCE_BARRIER_FLAGS
{
    D3D12_RESOURCE_BARRIER_FLAG_NONE = 0,
    D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY = 1,
    D3D12_RESOURCE_BARRIER_FLAG_END_ONLY = 2,
}
