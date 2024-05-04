#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_dsv_flags
[Flags]
public enum D3D12_DSV_FLAGS
{
    D3D12_DSV_FLAG_NONE = 0,
    D3D12_DSV_FLAG_READ_ONLY_DEPTH = 1,
    D3D12_DSV_FLAG_READ_ONLY_STENCIL = 2,
}
