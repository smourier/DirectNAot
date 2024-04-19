namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_fence_flags
[Flags]
public enum D3D12_FENCE_FLAGS
{
    D3D12_FENCE_FLAG_NONE = 0,
    D3D12_FENCE_FLAG_SHARED = 1,
    D3D12_FENCE_FLAG_SHARED_CROSS_ADAPTER = 2,
    D3D12_FENCE_FLAG_NON_MONITORED = 4,
}
