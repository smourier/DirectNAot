namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/ne-d3d11_3-d3d11_fence_flag
[Flags]
public enum D3D11_FENCE_FLAG
{
    D3D11_FENCE_FLAG_NONE = 0,
    D3D11_FENCE_FLAG_SHARED = 2,
    D3D11_FENCE_FLAG_SHARED_CROSS_ADAPTER = 4,
    D3D11_FENCE_FLAG_NON_MONITORED = 8,
}
