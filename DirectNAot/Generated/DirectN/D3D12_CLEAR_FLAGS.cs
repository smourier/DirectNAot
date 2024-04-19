namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_clear_flags
[Flags]
public enum D3D12_CLEAR_FLAGS
{
    D3D12_CLEAR_FLAG_DEPTH = 1,
    D3D12_CLEAR_FLAG_STENCIL = 2,
}
