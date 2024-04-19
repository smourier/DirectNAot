namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_multiple_fence_wait_flags
[Flags]
public enum D3D12_MULTIPLE_FENCE_WAIT_FLAGS
{
    D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE = 0,
    D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY = 1,
    D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL = 0,
}
